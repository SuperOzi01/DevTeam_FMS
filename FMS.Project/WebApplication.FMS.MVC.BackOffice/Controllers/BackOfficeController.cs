using ClassLibrary.FMS.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.BackOffice.Controllers
{
    public class BackOfficeController : Controller
    {
        public IActionResult MaintananceManagerDashboard(List<ServiceRequest> OpenRequestsList)
        {
            // Worker Username 
            // Open Requests ... New Requests... 
            return View(OpenRequestsList);
        }
        public IActionResult MaintananceManagerRequests()
        {
            // Worker Username 
            // Open Requests ... New Requests... 
            return View();
        }


    }
}
