﻿using ClassLibrary.FMS.DataModels;
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
            MM_RequestInfo_Model PageModel = new MM_RequestInfo_Model();
            PageModel.RequestInfo = ReqInforamationResponce;
            PageModel.WorkersList = WorkersListResponse;
            return View(PageModel);
        }

        public void ChangeRequestStatus(ServiceRequestAssignmentModel serviceRequest)
        {
            ViewBag.username = Request.Cookies["Username"];
            //var OpenRequestsList = 
            //return View();
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
            return View();
        }

        //worker Maintanance Requests
        public async Task<IActionResult> MaintananceWorkerRequests()
        {
            return View();
        }
        //worker Maintanance Requests Information
        public async Task<IActionResult> WorkerRequestsInfo()
        {
            return View();
        }


        // Building manager Dashboard
        public async Task<IActionResult> BuildingManagerDashboard()
        {
            return View();
        }

        // Building manager Requests
        public async Task<IActionResult> BuildingManagerMaintananceRequests()
        {
            return View();
        }
        // Building manager Requests Information
        public async Task<IActionResult>  BuildingManagerRequestsInfo()
        {
            return View();
        }

        // Beneficiaries Dashboard
        public async Task<IActionResult> BeneficiariesDashboard()
        {
            return View();
        }

        // Beneficiaries Requests
        public async Task<IActionResult> BeneficiariesMaintananceRequests()
        {
            return View();
        }
        // Beneficiaries New Requests 
        public async Task<IActionResult> CreateNewRequests()
        {
            return View();
        }
    }
}
