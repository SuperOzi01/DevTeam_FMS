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
                            
                           var OpenRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/MMOpenRequests", loginModel);
                            var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<ServiceRequest>>().Result;
                            int num = 1;
                            if(OpenRListResponce != null)
                            return RedirectToAction("MaintananceManagerDashboard","BackOffice", new { OpenRListResponce , num });
                        }



                        // the account is active and user does not need to update password
                        return RedirectToAction("MaintananceManagerDashboard","BackOffice");
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

        public IActionResult EmployeeRegistraion()
        {
            ViewBag.SpecializationList = GetSpecializationList();
            ViewBag.ManagerList = GetManagerList();
            ViewBag.LocationList = GetLocationList();
            ViewBag.RoleList = GetRoleList();
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeRegistraion(EmployeeRegistraionModel EmployeeRegistraion)
        {
            if (ModelState.IsValid)
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BaseUrl);
                var response = httpClient.PostAsJsonAsync("Api/Fms/EmployeeRegistraion", EmployeeRegistraion).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.SpecializationList = GetSpecializationList();
            ViewBag.ManagerList = GetManagerList();
            ViewBag.LocationList = GetLocationList();
            ViewBag.RoleList = GetRoleList();
            return View(EmployeeRegistraion);
        }


        private IEnumerable<SelectListItem> GetSpecializationList()
        {
            SelectList SpecializationName = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/GetSpecializationList").Result;
            if (response.IsSuccessStatusCode)
            {
                var SpecializationList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                SpecializationName = new SelectList(SpecializationList, "Value", "Text");
            }
            return SpecializationName;
        }
        private IEnumerable<SelectListItem> GetManagerList()
        {
            SelectList ManagerName = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/GetManagerList").Result;
            if (response.IsSuccessStatusCode)
            {
                var ManagerList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                ManagerName = new SelectList(ManagerList, "Value", "Text");
            }
            return ManagerName;
        }
        private IEnumerable<SelectListItem> GetLocationList()
        {
            SelectList LocationName = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/GetLocationList").Result;
            if (response.IsSuccessStatusCode)
            {
                var LocationList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                LocationName = new SelectList(LocationList, "Value", "Text");
            }
            return LocationName;
        }
        private IEnumerable<SelectListItem> GetRoleList()
        {
            SelectList RolenName = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/GetRoleList").Result;
            if (response.IsSuccessStatusCode)
            {
                var RoleList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                RolenName = new SelectList(RoleList, "Value", "Text");
            }
            return RolenName;
        }
    }
}
