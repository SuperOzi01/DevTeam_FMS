using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;
using WebApplication.FMS.WebAPI.AppFilters;
using ClassLibrary.FMS.DatabaseOperations;
using ClassLibrary.FMS.DataModels;

namespace WebApplication.FMS.WebAPI.Controllers
{
    public class FMSController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI Responce = new ResponseAPI();
        LoginOperations BenLogin = new LoginOperations();

        [Route("Api/Fms/ping")] 
        [HttpGet]
        [ExceptionFilter]
        public IHttpActionResult Ping()
        {
            // test the api logs and exceptions   
            //throw new DivideByZeroException();
            Responce.Message = "Ping is Working";
            Responce.Result = true;
            return Ok(Responce);
        }

        [Route("Api/Fms/HelthCheck")]
        [HttpGet]
        public IHttpActionResult HelthCheck()
        {
            // Here We Should ensure that: 
            // 1- JWT Working
            // 2- DB connection 
            // 3- Logs 
            Responce.Message = "Health Check is Working";
            Responce.Result = true;
            return Ok(Responce);
        }

        [Route("Api/Fms/Token")]
        [HttpPost]
        public IHttpActionResult Token(string username)
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            string token = new AuthinticationManager().Authinticate(username);
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


        [Route("Api/Fms/Login")]
        [HttpPost]
        public IHttpActionResult Login(LoginModel login)
        {

            bool result = BenLogin.Login(login);

            if (result == true)
            {
                
                return Token(login.Username);
            }
            else
            {
                Responce.Result = false;
                Responce.Message = "Login failed";
                return Ok(Responce);
            }

        }

        [Route("Api/Fms/BeneficiaryRegistraion")]
        [HttpPost]
        public IHttpActionResult BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            
            bool result = BenLogin.BeneficiaryRegistraion(BeneficiaryRegistraion);

            if (result == true)
            {
                Responce.Result = true;
                Responce.Message = "Beneficiary has been successfully registered";
            }
            else
            {
                Responce.Result = false;
                Responce.Message = "Registration failed";
            }
                return Ok(Responce);
        }

        [Route("Api/Fms/EmployeeRegistraion")]
        [HttpPost]
        public IHttpActionResult EmployeeRegistraion(EmployeeRegistraionModel EmployeeRegistraion)
        {

            bool result = BenLogin.EmployeeRegistraion(EmployeeRegistraion);

            if (result == true)
            {
                Responce.Result = true;
                Responce.Message = "Employee has been successfully registered";
            }
            else
            {
                Responce.Result = false;
                Responce.Message = "Registration failed";
            }
                return Ok(Responce);
        }

        [Route("Api/Fms/BeneficiaryRegistraion")]
        [HttpGet]
        public IHttpActionResult GetBuildingList()
        {
            var BuildingList = BenLogin.GetBuildingList();

                List<System.Web.Mvc.SelectListItem> list = new List<System.Web.Mvc.SelectListItem>();
                foreach (var item in BuildingList)
                {
                    list.Add(new System.Web.Mvc.SelectListItem()
                    {
                        Text = item.BuildingID.ToString(),
                        Value = item.BuildingID.ToString()
                    });
                }
                return Ok(list);
        }
        [Route("Api/Fms/GetSpecializationList")]
        [HttpGet]
        public IHttpActionResult GetSpecializationList()
        {
            var SpecializationList = BenLogin.GetSpecializationList();

            List<System.Web.Mvc.SelectListItem> list = new List<System.Web.Mvc.SelectListItem>();
            foreach (var item in SpecializationList)
            {
                list.Add(new System.Web.Mvc.SelectListItem()
                {
                    Text = item.SpecializationName.ToString(),
                    Value = item.SpecializationID.ToString()
                });
            }
            return Ok(list);
        }
        [Route("Api/Fms/GetManagerList")]
        [HttpGet]
        public IHttpActionResult GetManagerList()
        {
            var ManagerList = BenLogin.GetManagerList();

            List<System.Web.Mvc.SelectListItem> list = new List<System.Web.Mvc.SelectListItem>();
            foreach (var item in ManagerList)
            {
                list.Add(new System.Web.Mvc.SelectListItem()
                {
                    Text = item.Username.ToString(),
                    Value = item.EmployeeID.ToString()
                });
            }
            return Ok(list);
        }
        [Route("Api/Fms/GetLocationList")]
        [HttpGet]
        public IHttpActionResult GetLocationList()
        {
            var BuildingList = BenLogin.GetLocationList();

            List<System.Web.Mvc.SelectListItem> list = new List<System.Web.Mvc.SelectListItem>();
            foreach (var item in BuildingList)
            {
                list.Add(new System.Web.Mvc.SelectListItem()
                {
                    Text = item.City.ToString(),
                    Value = item.LocationID.ToString()
                });
            }
            return Ok(list);
        }
        [Route("Api/Fms/GetRoleList")]
        [HttpGet]
        public IHttpActionResult GetRoleList()
        {
            var BuildingList = BenLogin.GetRoleList();

            List<System.Web.Mvc.SelectListItem> list = new List<System.Web.Mvc.SelectListItem>();
            foreach (var item in BuildingList)
            {
                list.Add(new System.Web.Mvc.SelectListItem()
                {
                    Text = item.RoleName.ToString(),
                    Value = item.RoleID.ToString()
                });
            }
            return Ok(list);
        }
    }
}
