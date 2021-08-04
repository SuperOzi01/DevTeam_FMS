using ClassLibrary.FMS.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public IActionResult LoginPortal()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> LoginPortalAsync(LoginModel login)
        {
            var securityToken = string.Empty;
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BaseUrl);

                
                var response = await client.PostAsJsonAsync("Api/Fms/LoginPortal", login);
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


    }
}
