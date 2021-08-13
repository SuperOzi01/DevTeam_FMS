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
    [ExceptionFilterMVC]
    public class LoginController : Controller
    {
        string BaseUrl = Startup.GetBaseUrl();

        [Route("Ping")]
        public IActionResult ping()
        {

            throw new Exception();
            return Content("The Ping Page");
        }

        public IActionResult Signin() 
        {
            return View();
        }

        public IActionResult LoginPortal()
        {
            return View();
        }
        public IActionResult PopUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginPortal(LoginModel login)
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
                    return RedirectToAction("BeneficiariesDashboard", "PortalSystem");
                }
                else
                {
                    ViewBag.message = "Wrong Username or Password - or Account is not active";
                    return View();
                }
            }
            return View();
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
                    TempData["Ref"] = "Save";

                    //  return RedirectToAction("PopUp", "Login");
                }
            }
            ViewBag.BuildingList = GetBuilding();
            return View();
        }

        
        private IEnumerable<SelectListItem> GetBuilding()
        {
            SelectList ListOfBuilding = null;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = httpClient.GetAsync("Api/Fms/GetBuildingList").Result;
            if (response.IsSuccessStatusCode)
            {
                var BuildingList = response.Content.ReadAsAsync<IEnumerable<SelectListItem>>().Result;
                ListOfBuilding = new SelectList(BuildingList, "Value", "Text");
            }
            return ListOfBuilding;
        }


    }
}
