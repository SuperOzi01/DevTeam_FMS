using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Constants.ConstantStrings;
using ClassLibrary.FMS.DataModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
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

            return Content("Ping Is Successful");
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
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, null);


                var response = await client.PostAsJsonAsync( ConstantStrings.FMSControlerURL + "LoginPortal", login);
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
                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
                var httpRequest = await client.PostAsJsonAsync(ConstantStrings.FMSControlerURL +"BeneficiaryRegistraion", BeneficiaryRegistraion);
                if (httpRequest.IsSuccessStatusCode)
                {
                    var Response = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                    if (Response.Result == true)
                    {
                        TempData["Ref"] = "TrueReq";
                        return RedirectToAction("LoginPortal", "Login");
                    }
                    if (Response.Result == false)
                    {
                        ViewBag.Message = "This Account Already Exists";
                        ViewBag.BuildingList = await GetBuilding();
                        return View();
                    }
                }
            }
            ViewBag.BuildingList = await GetBuilding();
            return View();
        }

        
        private async Task<IEnumerable<SelectListItem>> GetBuilding()
        {
            List<SelectListItem> ListOfBuilding = new List<SelectListItem>();
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            var response = await client.GetAsync(ConstantStrings.FMSControlerURL + "GetBuildingList");
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
