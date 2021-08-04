using ClassLibrary.FMS.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace WebApplication.FMS.MVC.BackOffice.Controllers
{
    public class LoginController : Controller
    {
        string BaseUrl = Startup.GetBaseUrl();
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
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
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.message = "Wrong Username or Password";
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
