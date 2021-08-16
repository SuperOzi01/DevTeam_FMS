using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.FMS.MVC.Filters;
using WebApplication.FMS.MVC.Models;

namespace WebApplication.FMS.MVC.Controllers
{
    [LogsFilterMVC]
    [ExceptionFilterMVC]
    public class HomeController : Controller
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        private readonly ILogger<HomeController> _logger;

        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            InfoLog.Info("Successful");
            return View();            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
