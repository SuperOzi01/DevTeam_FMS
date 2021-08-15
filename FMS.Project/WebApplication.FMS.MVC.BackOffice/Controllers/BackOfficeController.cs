using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Constants.ConstantStrings;
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
    [ExceptionFilterMVC]
    [LogsFilterMVC]
    public class BackOfficeController : Controller
    {

        string BaseUrl = Startup.GetBaseUrl();


        public async Task<IActionResult> MaintananceManagerDashboard()
        {
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                List<SP_GetMMOpenRequests_Result> OpenRListResponce = new List<SP_GetMMOpenRequests_Result>();
                List<SP_GetMMClosedRequests_Result> closeRListResponce = new List<SP_GetMMClosedRequests_Result>();
                List<SP_GetMMApprovedRequests_Result> ApprovedListResponce = new List<SP_GetMMApprovedRequests_Result>();
                List<SP_CanceledServiceRequests_Result> CanceledListResponce = new List<SP_CanceledServiceRequests_Result>();

               var OpenRListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMOpenRequests");
                if(OpenRListRequest.IsSuccessStatusCode)
                     OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMCloseRequests");
                 if(closeRListRequest.IsSuccessStatusCode)
                    closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMApprovedRequests");
                if(ApprovedListRequest.IsSuccessStatusCode)
                 ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "CanceledRequests");
                if(CanceledListRequest.IsSuccessStatusCode)
                 CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;

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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            string username = Request.Cookies["Username"];
            if (username != null)
            {
                List<SP_GetMMOpenRequests_Result> OpenRListResponce = new List<SP_GetMMOpenRequests_Result>();
                List<SP_GetMMClosedRequests_Result> closeRListResponce = new List<SP_GetMMClosedRequests_Result>();
                List<SP_GetMMApprovedRequests_Result> ApprovedListResponce = new List<SP_GetMMApprovedRequests_Result>();
                List<SP_CanceledServiceRequests_Result> CanceledListResponce = new List<SP_CanceledServiceRequests_Result>();

                var OpenRListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMOpenRequests");
                if (OpenRListRequest.IsSuccessStatusCode)
                    OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMCloseRequests");
                if (closeRListRequest.IsSuccessStatusCode)
                    closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "MMApprovedRequests");
                if (ApprovedListRequest.IsSuccessStatusCode)
                    ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "CanceledRequests");
                if (CanceledListRequest.IsSuccessStatusCode)
                    CanceledListResponce = CanceledListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;

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



        public async Task<IActionResult> RequestsInfo(string ServiceType, int RequestNo)
        {

            ServiceRequestAssignmentModel serviceRequest = new ServiceRequestAssignmentModel();
            serviceRequest.RequestID = RequestNo;
            serviceRequest.EmployeeUsername = ServiceType;

            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            var ReqInforamationResponce = new SP_GetSpecificServiceRequestInfo_Result();
            var WorkersListResponse = new List<SP_GetWorkersOfSpecialization_Result>();

            var ReqInformation = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "GetRequestInfo", serviceRequest);
            if (ReqInformation.IsSuccessStatusCode)
                ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            var WorkersListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "GetWorkersList", serviceRequest);
            if (WorkersListRequest.IsSuccessStatusCode)
                WorkersListResponse = WorkersListRequest.Content.ReadAsAsync<List<SP_GetWorkersOfSpecialization_Result>>().Result;

            // New Model List , RequestInfo
            ViewBag.Username = Request.Cookies["Username"];
            ViewBag.WorkersList = WorkersListResponse;
            ViewBag.RequestInfo = ReqInforamationResponce;
            return View();
        }





        [HttpPost]
        public async Task RequestInfoClick(ServiceRequestAssignmentModel PageModel, string BtnValue)
        {
            if (BtnValue.Equals("Accept"))
                 await AcceptRequest(PageModel);
            else
                 await CancelRequest(PageModel);
        }

        public async Task<IActionResult> AcceptRequest(ServiceRequestAssignmentModel PageModel)
        {
            PageModel.EmployeeUsername = Request.Cookies["Username"];
            if (ModelState.IsValid)
            {
                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
                var httpResponse = new ResponseAPI();

                var httpRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "AcceptServiceRequest", PageModel);
                if (httpRequest.IsSuccessStatusCode)
                {
                    httpResponse = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                    if (httpResponse.Result)
                    {
                        if (PageModel.BuildingID == 1) // this request made by BM
                            return RedirectToAction("MaintananceManagerRequests");
                        else
                            return RedirectToAction("BuildingManagerMaintananceRequests");
                    }
                }
            }
            return Content("This Request Fails");
        }

        
        public async Task<IActionResult> CancelRequest(ServiceRequestAssignmentModel PageModel)
        {
            //Api/Fms/BackOffice/CancelRequest
            if(ModelState.IsValid)
            {
                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
                var httpRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "CancelRequest", PageModel);
                var httpResponce = httpRequest.Content.ReadAsAsync<ResponseAPI>().Result;

                if (httpResponce.Result)
                {
                    if (PageModel.BuildingID == 0)
                        return RedirectToAction("BuildingManagerMaintananceRequests"); // From The View Dont Add Username to the serviceRequest Object to know that this request is made by BM
                    else
                        return RedirectToAction("MaintananceManagerRequests");
                }
            }
            return Content("This Request Fails");
        }

        

        // worker Dashboard 
        public async Task<IActionResult> MaintananceWorkerDashboard()
        {
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                LoginModel user = new LoginModel() { Username = ViewBag.username };
                var OpenRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "WorkerOpenRequests", user);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "WorkerClosedRequests", user);
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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            string username = Request.Cookies["Username"];
            if (username != null)
            {
                LoginModel user = new LoginModel() { Username = username };
                var OpenRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "WorkerOpenRequests", user);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "WorkerClosedRequests", user);
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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            var ReqInformation = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "GetRequestInfo", serviceRequest);
            var ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            // New Model List , RequestInfo
            MM_RequestInfo_Model PageModel = new MM_RequestInfo_Model();
            PageModel.RequestInfo = ReqInforamationResponce;
            return View(PageModel);
        }


        [HttpPost]
        public async Task<IActionResult> CloseRequestByWorker(ServiceRequestAssignmentModel serviceRequest)
        {
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            var httpRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "AcceptServiceRequest", serviceRequest);
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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            ViewBag.username = Request.Cookies["Username"];
            if (ViewBag.username != null)
            {
                LoginModel user = new LoginModel() { Username = ViewBag.username };
                var BuildingNumberRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "ManagerBuildingNo", user);
                var BuildingNumberResponse = BuildingNumberRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                if (BuildingNumberResponse.Result != true)
                {
                    return Content("This BM Duesn't Manage Any Building");
                }
                
                int buildingNo;
                Int32.TryParse(BuildingNumberResponse.Message, out buildingNo);

                ServiceRequestAssignmentModel request = new ServiceRequestAssignmentModel() { BuildingID = buildingNo };
                var OpenRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerOpenServiceRequests", request);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetBMOpenedRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerClosedServiceRequests", request);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetBMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerMM_ApprovedServiceRequests" , request);
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetBM_MM_ApprovedRequesets_Result>>().Result;

                var CanceledListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerCanceledServiceRequests", request);
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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            string username = Request.Cookies["Username"];
            if (username != null)
            {

                LoginModel user = new LoginModel() { Username = username };
                var BuildingNumberRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "ManagerBuildingNo", user);
                var BuildingNumberResponse = BuildingNumberRequest.Content.ReadAsAsync<ResponseAPI>().Result;
                if (BuildingNumberResponse.Result != true && BuildingNumberResponse.Message != "0")
                {
                    return Content("This BM Duesn't Manage Any Building");
                }

                int buildingNo;
                Int32.TryParse(BuildingNumberResponse.Message, out buildingNo);

                ServiceRequestAssignmentModel request = new ServiceRequestAssignmentModel() { BuildingID = buildingNo };
                var OpenRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerOpenServiceRequests", request);
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

                var closeRListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerClosedServiceRequests", request);
                var closeRListResponce = closeRListRequest.Content.ReadAsAsync<List<SP_GetMMClosedRequests_Result>>().Result;

                var ApprovedListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerMM_ApprovedServiceRequests", request);
                var ApprovedListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_GetMMApprovedRequests_Result>>().Result;

                var CanceledListRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "BuildingManagerCanceledServiceRequests", request);
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
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            var ReqInformation = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "GetRequestInfo", serviceRequest);
            var ReqInforamationResponce = ReqInformation.Content.ReadAsAsync<SP_GetSpecificServiceRequestInfo_Result>().Result;

            // New Model List , RequestInfo
            ViewBag.Username = Request.Cookies["Username"];
            MM_RequestInfo_Model PageModel = new MM_RequestInfo_Model();
            PageModel.RequestInfo = ReqInforamationResponce;
            return View(PageModel);
        }

        /////////////////////////////////////////////////////////////////////
        public async Task<IActionResult> AdminDashboard()
        {
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);
            ViewBag.username = Request.Cookies["Username"];

            var WorkersRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "NumberOfWorkers");
            var WorkerResponse = WorkersRequest.Content.ReadAsAsync<int>().Result;
            
            var BeneficiariesRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "NumberOfBeneficiaries");
            var BeneficiariesResponse = BeneficiariesRequest.Content.ReadAsAsync<int>().Result;

            var OpenRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "NumberOfOpenRequests");
            var OpenResponse = OpenRequest.Content.ReadAsAsync<int>().Result;

            var ClosedRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "NumberOfClosedRequests");
            var ClosedResponse = ClosedRequest.Content.ReadAsAsync<int>().Result;

            ViewBag.Workers = WorkerResponse.ToString();
            ViewBag.Beneficiaries = BeneficiariesResponse.ToString();
            ViewBag.Open = OpenResponse.ToString();
            ViewBag.Closed = ClosedResponse.ToString();
            return View();
        }

        public async Task<IActionResult> AdminRegistrationRequests()
        {
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            // GET Api/Fms/BackOffice/ListOfNotActiveBeneficiaries"
            List<NotActiveUsersOfBuildingModel> PageModel = new List<NotActiveUsersOfBuildingModel>();
            var usersRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "ListOfNotActiveBeneficiaries");
            var usersResponse = usersRequest.Content.ReadAsAsync<List<NotActiveUsersOfBuildingModel>>().Result;

            if (usersResponse != null)
                PageModel = usersResponse;
                return View(PageModel);
        }


        public async Task<IActionResult> AcceptBeneficiary(LoginModel user)
        {
            if(user.Username != null)
            {

                // Post Api/Fms/BackOffice/ActivateBeneficiary
                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

                var ActivateRequest = await client.PostAsJsonAsync(ConstantStrings.BackOfficeControlerURL + "ActivateBeneficiary", user);
                var ActivateResponce = ActivateRequest.Content.ReadAsAsync<ResponseAPI>().Result;

                if(!ActivateResponce.Result)
                {
                    return Content(ActivateResponce.Message);
                }
                return RedirectToAction("AdminRegistrationRequests");
            }
            return Content("Username Not Found");

        }

        public async Task<IActionResult> AdminEmployeesList()
        {
            // GET Api/Fms/BackOffice/GetAllCompanyEmployees { List<SP_GetCompanyEmployeesList_Result> }
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            var EmployeesListRequest = await client.GetAsync(ConstantStrings.BackOfficeControlerURL + "GetAllCompanyEmployees");
            var EmployeesListResponce = EmployeesListRequest.Content.ReadAsAsync<List<SP_GetCompanyEmployeesList_Result>>().Result;
            
            ViewBag.WorkersList = EmployeesListResponce;
            ViewBag.SpecializationList = GetSpecializationList();
            ViewBag.ManagerList = GetManagerList();
            ViewBag.LocationList = GetLocationList();
            ViewBag.RoleList = GetRoleList();
            ViewBag.Result = false;

            EmployeeRegistraionModel InsertModel = new EmployeeRegistraionModel();
            return View(InsertModel);
        }


        [HttpPost]
        public IActionResult EmployeeRegistraion(EmployeeRegistraionModel EmployeeRegistraion)
        {
            if (ModelState.IsValid)
            {
                string HeaderValue = Request.Cookies["securityToken"];
                HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

                var RequestList = client.PostAsJsonAsync(ConstantStrings.FMSControlerURL + "EmployeeRegistraion", EmployeeRegistraion).Result;
                if (RequestList.IsSuccessStatusCode)
                {
                    var Response = RequestList.Content.ReadAsAsync<ResponseAPI>().Result;
                    if (Response.Result == true)
                        ViewBag.Result = true;
                    else
                        ViewBag.Result = false;

                    return RedirectToAction("AdminEmployeesList");
                }
            }
            return RedirectToAction("AdminEmployeesList");
        }


        public List<SelectListItem> GetSpecializationList()
        {
            List<SelectListItem> SpecializationName = new List<SelectListItem>();
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            var RequestList = client.GetAsync(ConstantStrings.FMSControlerURL + "GetSpecializationList").Result;
            if (RequestList.IsSuccessStatusCode)
            {
                var Response = RequestList.Content.ReadAsAsync<List<SP_GetAllSpecializations_Result>>().Result;
                foreach (var item in Response)
                {
                    SpecializationName.Add(new SelectListItem(item.SpecializationName, item.SpecializationID.ToString()));
                }
            }
            return SpecializationName;
        }
        private List<SelectListItem> GetManagerList()
        {
            List<SelectListItem> ManagerName = new List<SelectListItem>();
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            var RequestList = client.GetAsync(ConstantStrings.FMSControlerURL + "GetManagerList").Result;
            if (RequestList.IsSuccessStatusCode)
            {
                var Response = RequestList.Content.ReadAsAsync<List<SP_MaintananceManagersList_Result>>().Result;
                foreach (var item in Response)
                {
                    ManagerName.Add(new SelectListItem(item.FirstName + " " + item.LastName, item.EmployeeID.ToString()));
                }
            }
            return ManagerName;
        }
        private List<SelectListItem> GetLocationList()
        {
            List<SelectListItem> LocationName = new List<SelectListItem>();
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            var RequestList = client.GetAsync(ConstantStrings.FMSControlerURL + "GetLocationList").Result;
            if (RequestList.IsSuccessStatusCode)
            {
                var Response = RequestList.Content.ReadAsAsync<List<SP_GetAllLocations_Result>>().Result;
                foreach (var item in Response)
                {
                    LocationName.Add(new SelectListItem(item.City, item.LocationID.ToString()));
                }
            }
            return LocationName;
        }
        private List<SelectListItem> GetRoleList()
        {
            List<SelectListItem> RolenName = new List<SelectListItem>();
            string HeaderValue = Request.Cookies["securityToken"];
            HttpClient client = HttpClientCreator.CreateHttpClient(BaseUrl, HeaderValue);

            var RequestList = client.GetAsync(ConstantStrings.FMSControlerURL + "GetRoleList").Result;
            if (RequestList.IsSuccessStatusCode)
            {
                var Response = RequestList.Content.ReadAsAsync<List<SP_GetAllRoles_Result>>().Result;
                foreach (var item in Response)
                {
                    if (item.RoleName.Equals(ConstantStrings.Role_SystemAdmin) || item.RoleName.Equals(ConstantStrings.Role_Employee) || item.RoleName.Equals(ConstantStrings.Role_Beneficiary))
                        continue;
                    RolenName.Add(new SelectListItem(item.RoleName, item.RoleID.ToString()));
                }
            }
            return RolenName;
        }

        public ActionResult Logout()
        {
            return RedirectToAction("EmployeeLogin", "Login");
        }


    }
}
