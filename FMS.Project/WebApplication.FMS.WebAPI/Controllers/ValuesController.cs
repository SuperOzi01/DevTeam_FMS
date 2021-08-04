using ClassLibrary.FMS.DataModels;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.FMS.WebAPI.App_Start;

namespace WebApplication.FMS.WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI r = new ResponseAPI();
        // GET api/values
        [AuthorizationManager]
        public IEnumerable<string> Get()
        {
            try
            {
                return new string[] { "value1", "value2" };
            }
            catch (Exception ex)
            {
                ErrorLog.Error(ex.Message);
                r.Message = "Something went wrong.";
                return new string[] { "error" };
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [Route("UserLogin")]
        [AllowAnonymous]
        public ResponseAPI UserLogin()
        {
            try
            {
                InfoLog.Info("successful");
                return new ResponseAPI
                    {
                        Result = true,
                       // Message = TokenManager.GenerateToken()
                    };
            }
            catch (Exception ex)
            {
                ErrorLog.Error(ex.Message);
                return new ResponseAPI
                {
                    Result = false,
                    Message = "Something went wrong."
                };
            }
        }
    }
}
