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

namespace WebApplication.FMS.MVC.BackOffice.Controllers
{
    public class BackOfficeController : Controller
    {

        string BaseUrl = Startup.GetBaseUrl();
        public async Task<IActionResult> MaintananceManagerDashboard()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                var OpenRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMOpenRequests");
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMCloseRequests");
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.GetAsync("Api/Fms/BackOffice/MMApprovedRequests");
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.GetAsync("Api/Fms/BackOffice/CanceledRequests");
                var CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;

                ViewBag.NoNewRequests = OpenRListResponce.Count;
                ViewBag.NoOpenedRequests = ApprovedListResponce.Count;
                ViewBag.NoClosedRequests = closeRListResponce.Count;
                ViewBag.NoCanceledRequests = CanceledListResponce.Count;

                // Worker Username 
                return View(OpenRListResponce);
            }
            return Content("username not found");
            // Open Requests ... New Requests... 
        }
        public async Task<IActionResult> MaintananceManagerRequests()
        {
            // Worker Username 
            // Open Requests ... New Requests... 
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username != null)
            {
                var OpenRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMOpenRequests");
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMCloseRequests");
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.GetAsync("Api/Fms/BackOffice/MMApprovedRequests");
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.GetAsync("Api/Fms/BackOffice/CanceledRequests");
                var CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;

                MaintenanceManagerModel mymodel = new MaintenanceManagerModel();
                mymodel.OpenRequests = OpenRListResponce;
                mymodel.ClosedRequests = closeRListResponce;
                mymodel.ApprovedRequests = ApprovedListResponce;
                mymodel.CanceledRequests = CanceledListResponce;

                // Worker Username 
                return View(mymodel);
            }
            return Content("username not found");
            // Open Requests ... New Requests... 
        }

        public async Task<IActionResult> RequestsInfo(ServiceRequestAssignmentModel serviceRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var ReqInformation = await client.PostAsJsonAsync("Api/Fms/BackOffice/GetRequestInfo", serviceRequest);
            var ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            var WorkersListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/GetWorkersList", serviceRequest);
            var WorkersListResponse = WorkersListRequest.Content.ReadAsAsync<List<SP_GetWorkersOfSpecialization_Result>>().Result;

            // New Model List , RequestInfo
            ViewBag.RequestInfo = ReqInforamationResponce;
            ViewBag.WorkersList = WorkersListResponse;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RequestInfoClick(ServiceRequestAssignmentModel serviceRequest, string BtnValue)
        {
            if (BtnValue.Equals("Accept"))
                return await AcceptRequest(serviceRequest);
            else
                return await CancelRequest(serviceRequest);
        }

        public async Task<IActionResult> AcceptRequest(ServiceRequestAssignmentModel serviceRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var httpRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/AcceptServiceRequest", serviceRequest);
            var httpResponce = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;
            if (httpResponce.Result)
            {
                if (serviceRequest.EmployeeUsername != null && serviceRequest.BuildingID == 0) // this request made by BM
                    return RedirectToAction("MaintananceManagerRequests");
                else
                    return RedirectToAction("BuildingManagerMaintananceRequests");
            }
            return Content("This Request Fails");
        }

        
        public async Task<IActionResult> CancelRequest(ServiceRequestAssignmentModel serviceRequest)
        { 
            //Api/Fms/BackOffice/CancelRequest
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var httpRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/CancelRequest", serviceRequest);
            var httpResponce = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;
            
            if(httpResponce.Result)
            {
                if (serviceRequest.BuildingID != 0)
                    return RedirectToAction("BuildingManagerMaintananceRequests"); // From The View Dont Add Username to the serviceRequest Object to know that this request is made by BM
                else
                    return RedirectToAction("MaintananceManagerRequests");
            }
            return Content("This Request Fails");
        }

        private List<SelectListItem> GetEmployeeList(List<SP_GetWorkersOfSpecialization_Result> list)
        {
            List<SelectListItem> responceItems = new List<SelectListItem>();
            foreach (var item in list)
            {
                responceItems.Add(new SelectListItem()
                {
                    Text = item.FirstName.ToString() + " " + item.LastName.ToString(),
                    Value = item.EmployeeID.ToString()
                });
            }
            return responceItems;
        }

        // worker Dashboard 
        public async Task<IActionResult> MaintananceWorkerDashboard()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                LoginModel user = new LoginModel() { Username = ViewBag.username };
                var OpenRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/WorkerOpenRequests", user);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/WorkerClosedRequests", user);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                ViewBag.NoNewRequests = OpenRListResponce.Count;
                ViewBag.NoClosedRequests = closeRListResponce.Count;

                // Worker Username 
                return View(OpenRListResponce);
            }
            return Content("username not found");
        }

        //worker Maintanance Requests
        public async Task<IActionResult> MaintananceWorkerRequests()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username != null)
            {
                LoginModel user = new LoginModel() { Username = username };
                var OpenRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/WorkerOpenRequests", user);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/WorkerClosedRequests", user);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                MaintenanceManagerModel mymodel = new MaintenanceManagerModel();
                mymodel.OpenRequests = OpenRListResponce;
                mymodel.ClosedRequests = closeRListResponce;

                // Worker Username 
                return View(mymodel);
            }
            return Content("username not found");
        }
        //worker Maintanance Requests Information
        public async Task<IActionResult> WorkerRequestsInfo(ServiceRequestAssignmentModel serviceRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var ReqInformation = await client.PostAsJsonAsync("Api/Fms/BackOffice/GetRequestInfo", serviceRequest);
            var ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            // New Model List , RequestInfo
            MM_RequestInfo_Model PageModel = new MM_RequestInfo_Model();
            PageModel.RequestInfo = ReqInforamationResponce;
            return View(PageModel);
        }


        [HttpPost]
        public async Task<IActionResult> CloseRequestByWorker(ServiceRequestAssignmentModel serviceRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var httpRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/AcceptServiceRequest", serviceRequest);
            var httpResponce = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;
            if(httpResponce.Result != true)
            {
                return Content("The Task Is Not Ok");
            }
            return RedirectToAction("MaintananceWorkerRequests");
        }

        // Building manager Dashboard 
        public async Task<IActionResult> BuildingManagerDashboard()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                LoginModel user = new LoginModel() { Username = ViewBag.username };
                var BuildingNumberRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/ManagerBuildingNo", user);
                var BuildingNumberResponse = BuildingNumberRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                if (BuildingNumberResponse.Result != true)
                {
                    return Content("This BM Duesn't Manage Any Building");
                }
                
                int buildingNo;
                Int32.TryParse(BuildingNumberResponse.Message, out buildingNo);

                ServiceRequestAssignmentModel request = new ServiceRequestAssignmentModel() { BuildingID = buildingNo };
                var OpenRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerOpenServiceRequests", request);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetBMOpenedRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerClosedServiceRequests", request);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetBMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerMM_ApprovedServiceRequests" , request);
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetBM_MM_ApprovedRequesets_Result>>().Result;

                var CanceledListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerCanceledServiceRequests", request);
                var CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_BMCanceledRequests_Result>>().Result;

                ViewBag.NoNewRequests = OpenRListResponce.Count;
                ViewBag.NoOpenedRequests = ApprovedListResponce.Count;
                ViewBag.NoClosedRequests = closeRListResponce.Count;
                ViewBag.NoCanceledRequests = CanceledListResponce.Count;

                // Worker Username 
                return View(OpenRListResponce);
            }
            return Content("username not found");
            // Open Requests ... New Requests...
        }

        // Building manager Requests
        public async Task<IActionResult> BuildingManagerMaintananceRequests()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username != null)
            {

                LoginModel user = new LoginModel() { Username = username };
                var BuildingNumberRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/ManagerBuildingNo", user);
                var BuildingNumberResponse = BuildingNumberRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                if (BuildingNumberResponse.Result != true && BuildingNumberResponse.Message != "0")
                {
                    return Content("This BM Duesn't Manage Any Building");
                }

                int buildingNo;
                Int32.TryParse(BuildingNumberResponse.Message, out buildingNo);

                ServiceRequestAssignmentModel request = new ServiceRequestAssignmentModel() { BuildingID = buildingNo };
                var OpenRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerOpenServiceRequests", request);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerClosedServiceRequests", request);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerMM_ApprovedServiceRequests", request);
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.PostAsJsonAsync("Api/Fms/BackOffice/BuildingManagerCanceledServiceRequests", request);
                var CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;

                MaintenanceManagerModel mymodel = new MaintenanceManagerModel();
                mymodel.OpenRequests = OpenRListResponce;
                mymodel.ClosedRequests = closeRListResponce;
                mymodel.ApprovedRequests = ApprovedListResponce;
                mymodel.CanceledRequests = CanceledListResponce;

                // Worker Username 
                return View(mymodel);
            }
            return Content("username not found");
        }
        // Building manager Requests Information
        public async Task<IActionResult>  BuildingManagerRequestsInfo(ServiceRequestAssignmentModel serviceRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            var ReqInformation = await client.PostAsJsonAsync("Api/Fms/BackOffice/GetRequestInfo", serviceRequest);
            var ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            // New Model List , RequestInfo
            MM_RequestInfo_Model PageModel = new MM_RequestInfo_Model();
            PageModel.RequestInfo = ReqInforamationResponce;
            return View(PageModel);
        }

        /////////////////////////////////////////////////////////////////////
        public async Task<IActionResult> AdminDashboard()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            ViewBag.username = Request.Cookies["Username"];

            var WorkersRequest = await client.GetAsync("Api/Fms/BackOffice/NumberOfWorkers");
            var WorkerResponse = WorkersRequest.Content.ReadAsAsync<int>().Result;
            
            var BeneficiariesRequest = await client.GetAsync("Api/Fms/BackOffice/NumberOfBeneficiaries");
            var BeneficiariesResponse = BeneficiariesRequest.Content.ReadAsAsync<int>().Result;

            var OpenRequest = await client.GetAsync("Api/Fms/BackOffice/NumberOfOpenRequests");
            var OpenResponse = OpenRequest.Content.ReadAsAsync<int>().Result;

            var ClosedRequest = await client.GetAsync("Api/Fms/BackOffice/NumberOfClosedRequests");
            var ClosedResponse = ClosedRequest.Content.ReadAsAsync<int>().Result;

            ViewBag.Workers = WorkerResponse.ToString();
            ViewBag.Beneficiaries = BeneficiariesResponse.ToString();
            ViewBag.Open = OpenResponse.ToString();
            ViewBag.Closed = ClosedResponse.ToString();
            return View();
        }

        public IActionResult AdminRegistrationRequests()
        {
            // GET Api/Fms/BackOffice/ListOfNotActiveBeneficiaries"
            List<NotActiveUsersOfBuildingModel> PageModel = new List<NotActiveUsersOfBuildingModel>();
            return View();
        }


        public IActionResult AdminEmployeesList()
        {
            return View();
        }


    }
}
