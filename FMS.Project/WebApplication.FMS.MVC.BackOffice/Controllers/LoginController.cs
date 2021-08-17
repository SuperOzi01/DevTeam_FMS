using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Constants.ConstantStrings;
using ClassLibrary.FMS.DataModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.FMS.MVC.Filters;

namespace WebApplication.FMS.MVC.BackOffice.Controllers
{
    [LogsFilterMVC]
    [ExceptionFilterMVC]
    public class LoginController : Controller
    {
        string BaseUrl = Startup.GetBaseUrl();
        // GET: LoginController

        
        public ActionResult UpdatePasswordPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePasswordPageAsync(UpdatePasswordModel updatePasswordModel)
        {
            if (ModelState.IsValid)
            {
                if(updatePasswordModel.RePassword != updatePasswordModel.Password)
                {
                    ViewBag.ValidationMessage = "Password fields does not match";
                    return View();
                }
                
                if(Request.Cookies["Username"] != null)
                updatePasswordModel.Username = Request.Cookies["Username"].ToString();


                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
                var response = await client.PostAsJsonAsync(ConstantStrings.FMSControlerURL + "BackOfficeUpdatePasswordAndStatus", updatePasswordModel);
                var resultMessage = response.Content.ReadAsAsync<ResponseAPI>().Result;
                if (resultMessage.Result == true)
                {
                    TempData["Ref"] = "TrueReq";
                    return RedirectToAction("EmployeeLogin","Login");
                }
            }
            return RedirectToAction("Index","Home");
        }



        public ActionResult EmployeeLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmployeeLogin(LoginModel loginModel)
        {
            var securityToken = string.Empty;
            if (ModelState.IsValid)
            {
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, null);


                var response = await client.PostAsJsonAsync(ConstantStrings.FMSControlerURL + "LoginBackOffice", loginModel);
                var resultMessage = response.Content.ReadAsAsync<ResponseAPI>().Result;
                if (resultMessage.Result == true)
                {
                    securityToken = resultMessage.Message;
                    HttpContext.Response.Cookies.Append("Username", loginModel.Username);
                    HttpContext.Response.Cookies.Append("securityToken", securityToken);

                    var statusRequest = await client.PostAsJsonAsync(ConstantStrings.FMSControlerURL + "BackOfficeAccountStatus", loginModel);
                    var statusResponce = statusRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                    if(statusResponce.Result == true)
                    {
                        // Check what page to redirect to based on the role. 
                        var userRoleRequest = await client.PostAsJsonAsync(ConstantStrings.FMSControlerURL + "GetUserRole", loginModel);
                        var userRoleResponce = userRoleRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                        if(userRoleResponce.Result == false)
                        {
                            return View("ErrorView");
                        }

                        if(userRoleResponce.Message.Equals("Maintenance Manager"))
                        {
                            return RedirectToAction("MaintananceManagerDashboard","BackOffice");
                        } 
                        else if(userRoleResponce.Message.Equals("Maintenance Worker"))
                        {
                            return RedirectToAction("MaintananceWorkerDashboard", "BackOffice");
                        }
                        else if(userRoleResponce.Message.Equals("Building Manager"))
                        {
                            return RedirectToAction("BuildingManagerDashboard", "BackOffice");
                        }
                        else if (userRoleResponce.Message.Equals("System Adminstrator"))
                        {
                            return RedirectToAction("AdminDashboard", "BackOffice");
                        }
                        else
                        {
                            // The User Is Not in any Authorized Role 
                            return RedirectToAction("Index", "Home");
                        }

                    }
                    // take the user to update password page
                    return RedirectToAction("UpdatePasswordPage", "Login");

                }
                else
                {
                    ViewBag.message = "Wrong Username or Password - or Account is not active";
                    return View();
                }
            }
            return View("ErrorView");
        }



    }
}
