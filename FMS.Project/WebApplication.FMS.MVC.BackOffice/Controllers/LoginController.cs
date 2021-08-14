using ClassLibrary.FMS.DataModels;
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


                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl);
                var response = await client.PostAsJsonAsync("Api/Fms/BackOfficeUpdatePasswordAndStatus", updatePasswordModel);
                var resultMessage = response.Content.ReadAsAsync<ResponseAPI>().Result;
                if (resultMessage.Result == true)
                {
                    return Content("Worked");
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
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl);


                var response = await client.PostAsJsonAsync("Api/Fms/LoginBackOffice", loginModel);
                var resultMessage = response.Content.ReadAsAsync<ResponseAPI>().Result;
                if (resultMessage.Result == true)
                {
                    securityToken = resultMessage.Message;
                    HttpContext.Response.Cookies.Append("Username", loginModel.Username);
                    HttpContext.Response.Cookies.Append("securityToken", securityToken);

                    var statusRequest = await client.PostAsJsonAsync("Api/Fms/BackOfficeAccountStatus", loginModel);
                    var statusResponce = statusRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                    if(statusResponce.Result == true)
                    {
                        // Check what page to redirect to based on the role. 
                        var userRoleRequest = await client.PostAsJsonAsync("Api/Fms/GetUserRole", loginModel);
                        var userRoleResponce = userRoleRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                        if(userRoleResponce.Result == false)
                        {
                            return Content("This user Is Not Found");
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
            return Content(securityToken);
        }



    }
}
