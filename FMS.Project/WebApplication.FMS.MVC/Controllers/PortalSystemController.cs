using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.Portal.Controllers
{
    public class PortalSystemController : Controller
    {
        string BaseUrl = Startup.GetBaseUrl();
        // Beneficiaries Dashboard
        public async Task<IActionResult> BeneficiariesDashboard()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username == null)
                return Content("User Not Found");

            LoginModel login = new LoginModel();
            login.Username = username;

            var OpenRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/OpenRequests", login);
            var OpenResponce = OpenRequest.Content.ReadAsAsync<List<SP_GetBeneficiaryOpenRequests_Result>>().Result;

            var ClosedRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/ClosedRequests", login);
            var ClosedResponce = ClosedRequest.Content.ReadAsAsync<List<SP_GetBeneficiaryCloseedRequest_Result>>().Result;

            ViewBag.username = username;
            ViewBag.NoOpenedRequests = OpenResponce.Count;
            ViewBag.NoClosedRequests = ClosedResponce.Count;
            return View(OpenResponce);
        }

        // Beneficiaries Requests
        public async Task<IActionResult> BeneficiariesMaintananceRequests()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username == null)
                return Content("User Not Found");

            LoginModel login = new LoginModel();
            login.Username = username;

            var OpenRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/OpenRequests", login);
            var OpenResponce = OpenRequest.Content.ReadAsAsync<List<SP_GetBeneficiaryOpenRequests_Result>>().Result;

            var ClosedRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/ClosedRequests", login);
            var ClosedResponce = ClosedRequest.Content.ReadAsAsync<List<SP_GetBeneficiaryCloseedRequest_Result>>().Result;

            var CanceledRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/CanceledRequests", login);
            var CanceledResponce = CanceledRequest.Content.ReadAsAsync<List<SP_GetBeneficiaryCanceledRequests_Result>>().Result;

            ViewBag.OpenList = OpenResponce;
            ViewBag.ClosedList = ClosedResponce;
            ViewBag.CanceledList = CanceledResponce;
            return View();
        }
        // Beneficiaries New Requests 
        public async Task<IActionResult> CreateNewRequests()
        {
            // GET Api/Fms/GetSpecializationList
            // POST API/Fms/PortalSystem/BeneficiaryBuilding {LoginModel}

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username == null)
                return Content("User Not Found");

            LoginModel login = new LoginModel();
            login.Username = username;

            var BuildingRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/BeneficiaryBuilding", login);
            var BuildingResponce = BuildingRequest.Content.ReadAsAsync<ResponseAPI>().Result;

            var ServiceRequest = await client.GetAsync("Api/Fms/GetSpecializationList");
            var ServiceRequestResponce = ServiceRequest.Content.ReadAsAsync<List<SP_GetAllSpecializations_Result>>().Result;

            int number = 0;
            Int32.TryParse(BuildingResponce.Message, out number);
            if (number == 0)
                return Content("Building Was Not Found");

            ViewBag.Username = username;
            ViewBag.BuildingNumber = number;
            ViewBag.ServicesList = ServiceRequestResponce;
            NewServiceRequestModel Model = new NewServiceRequestModel();
            return View(Model);
        }

        public async Task<IActionResult> SubmitCreateRequest(NewServiceRequestModel request)
        {
            // POST API/Fms/PortalSystem/CreateRequest {NewServiceRequestModel} 
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);

            var CreationRequest = await client.PostAsJsonAsync("API/Fms/PortalSystem/CreateRequest", request);
            var CreationResponce = CreationRequest.Content.ReadAsAsync<ResponseAPI>().Result;
            if (CreationResponce.Result == true)
                return RedirectToAction("BeneficiariesMaintananceRequests");
            else
                return Content(CreationResponce.Message);
        }
    }
}
