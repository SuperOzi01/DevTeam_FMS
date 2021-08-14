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

        public async Task<IActionResult> BeneficiaryRegistraion()
        {
            ViewBag.BuildingList = await GetBuilding();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BeneficiaryRegistraionAsync(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            if (ModelState.IsValid)
            { 
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(BaseUrl);
                var Request = await httpClient.PostAsJsonAsync("Api/Fms/BeneficiaryRegistraion", BeneficiaryRegistraion);
                if (Request.IsSuccessStatusCode)
                {
                    var Response = Request.Content.ReadAsAsync<ResponseAPI>().Result;
                    if(Response.Result == true)
                        return RedirectToAction("LoginPortal", "Login");
                    if (Response.Result == false)
                        ViewBag.Message = "This Account Already Exists";
                        ViewBag.BuildingList = await GetBuilding();
                        return View();
                }
            }
            ViewBag.BuildingList = await GetBuilding();
            return View();
        }

        
        private async Task<IEnumerable<SelectListItem>> GetBuilding()
        {
            List<SelectListItem> ListOfBuilding = new List<SelectListItem>();
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BaseUrl);
            var response = await httpClient.GetAsync("Api/Fms/GetBuildingList");
            if (response.IsSuccessStatusCode)
            {
                var buildingResponse = response.Content.ReadAsAsync<List<SP_GetAllBuildings_Result>>().Result;
                foreach(SP_GetAllBuildings_Result item in buildingResponse)
                {
                    ListOfBuilding.Add(new SelectListItem(item.BuildingID.ToString(), item.BuildingID.ToString()));
                }
            }
            return ListOfBuilding;
        }


    }
}
