using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.FMS.DataModels;
using WebApplication.FMS.WebAPI.AppFilters;

namespace WebApplication.FMS.WebAPI.Controllers
{
    public class FMSController : ApiController
    {
        [Route("Api/Fms/ping")] 
        [HttpGet]
        [ExceptionFilter]
        public IHttpActionResult Ping()
        {
            // test the api logs and exceptions   
            throw new DivideByZeroException();
            return Ok(("Ok" , HttpStatusCode.OK));
        }

        [Route("Api/Fms/HelthCheck")]
        [HttpGet]
        public IHttpActionResult HelthCheck()
        {
            // Here We Should ensure that: 
            // 1- JWT Working
            // 2- DB connection 
            // 3- Logs 
            return Ok(("Ok", HttpStatusCode.OK));
        }

        [Route("Api/Fms/Token")]
        [HttpPost]
        public IHttpActionResult Token()
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            string token = new AuthinticationManager().Authinticate("Username" , "Password");
            return Ok((token, HttpStatusCode.OK));
        }

        [AuthorizationManager(Roles = "test")]
        [Route("Api/Fms/validate")]
        [HttpPost]
        public IHttpActionResult Validate()
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            return Ok((true, HttpStatusCode.OK));
        }

    }
}
