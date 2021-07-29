using ClassLibrary.FMS.DataModels;
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
        // GET api/values
        //[Authorization]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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

        /*[Route("UserLogin")]
        [AllowAnonymous]
        public ResponseAPI UserLogin()
        {
            try
            {
                    return new ResponseAPI
                    {
                        Result = true,
                        Message = TokenManager.GenerateToken()
                    };
            }
            catch (Exception ex)
            {
                return new ResponseAPI
                {
                    Result = false,
                    Message = "Something went wrong."
                };
            }
        }*/
    }
}
