using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.FMS.WebAPI.Controllers
{
    public class FMSController : ApiController
    {
        [Route("api/fms/ping")]
        [HttpGet]
        public IHttpActionResult Ping()
        {
            return Ok(("Ok" , HttpStatusCode.OK));
        }

        [Route("api/fms/HelthCheck")]
        [HttpGet]
        public IHttpActionResult HelthCheck()
        {
            // Here We Should ensure that the connection to DB is running ..  
            return Ok(("Ok", HttpStatusCode.OK));
        }

    }
}
