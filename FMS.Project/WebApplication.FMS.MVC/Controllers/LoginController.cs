using ClassLibrary.FMS.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication.FMS.MVC.Filters;

namespace WebApplication.FMS.MVC.Controllers
{
    [LogsFilterMVC]
    public class LoginController : Controller
    {
        string BaseUrl = Startup.GetBaseUrl();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signin() 
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel login)
        {
            var securityToken = string.Empty;
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl);

                
                var response = await client.PostAsJsonAsync("Api/Fms/Login", login);
                var resultMessage = response.Content.ReadAsAsync<ResponseAPI>().Result;
                if (resultMessage.Result == true)
                {
                    securityToken = resultMessage.Message;
                    HttpContext.Response.Cookies.Append("Username", login.Username);
                    HttpContext.Response.Cookies.Append("securityToken", securityToken);
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ViewBag.message = "Wrong Username or Password";
                    return View();
                }
            }
            return Content(securityToken);
        }

        // On Validation use this line 
        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.HttpContext.Request.Cookies["securityToken"]);

        public IActionResult BeneficiaryRegistraion()
        {
            ViewBag.BuildingList = GetBuilding();
            return View();
        }
        [HttpPost]
        public IActionResult BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            if (ModelState.IsValid)
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BaseUrl);
                var response = httpClient.PostAsJsonAsync("Api/Fms/BeneficiaryRegistraion", BeneficiaryRegistraion).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.BuildingList = GetBuilding();
            return View(BeneficiaryRegistraion);
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
        private IEnumerable<SelectListItem> GetBuilding()
        {
            SelectList ListOfBuilding = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/BeneficiaryRegistraion").Result;
            if (response.IsSuccessStatusCode)
            {
                var BuildingList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                ListOfBuilding = new SelectList(BuildingList, "Value", "Text");
            }
            return ListOfBuilding;
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
