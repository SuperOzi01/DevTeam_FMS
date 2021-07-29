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

    }
}
