using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.Portal.Controllers
{
    public class PortalSystemController : Controller
    {

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
