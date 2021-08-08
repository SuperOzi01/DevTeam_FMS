using ClassLibrary.FMS.DataModels;
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
        public IActionResult MaintananceManagerRequests()
        {
            // Worker Username 
            // Open Requests ... New Requests... 
            return View();
        }

        public async Task<IActionResult> MaintananceManagerDashboard2()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            string username = Request.Cookies["Username"];
            if (username != null)
            {
                var OpenRListRequest = await client.GetAsync("Api/Fms/BackOffice/MMOpenRequests");
                var OpenRListResponce = OpenRListRequest.Content.ReadAsAsync<List<SP_GetMMOpenRequests_Result>>().Result;
                // Worker Username 
                return View(OpenRListResponce);
            }
            return Content("username not found");
            // Open Requests ... New Requests... 
        }


    }
}
