using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            string username = Request.Cookies["Username"];
            if(username != null)
            {
            var OpenRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMOpenRequests");
            var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;

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
                var CanceledListRequest = await client.GetAsync("Api/Fms/BackOffice/CancelRequest");
                var CanceledListResponce = ApprovedListRequest.Content.ReadAsAsync<List<SP_CanceledServiceRequests_Result>>().Result;
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

        public async Task<IActionResult> RequestsInfo()
        {
            return View();
        }


        }
}
