using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginPortalUi()
        {
            return View();
        }

        public IActionResult Signin() 
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
    }
}
