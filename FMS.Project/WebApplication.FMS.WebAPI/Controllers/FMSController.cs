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
using WebApplication.FMS.WebAPI.App_Start;
using ClassLibrary.FMS.DataModels.Models;

namespace WebApplication.FMS.WebAPI.Controllers
{
    [ExceptionFilter]
    [LogsFilterWebAPI]
    public class FMSController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI Response = new ResponseAPI();
        private LoginOperations loginOperationsObject = new LoginOperations();

        public FMSController() { }

        [Route("Api/Fms/ping")] 
        [HttpGet]
        public IHttpActionResult Ping()
        {
            // test the api logs and exceptions   
            Response.Message = "Ping is Working";
            Response.Result = true;
            return Ok(Response);
        }

        [Route("Api/Fms/HelthCheck")]
        [HttpGet]
        public IHttpActionResult HelthCheck()
        {
            // Here We Should ensure that: 
            // 1- JWT Working
            
            // 2- DB connection 
            int result = loginOperationsObject.TestDB();
            // 3- Logs
            throw new DivideByZeroException();
        }

        [Route("Api/Fms/Token")]
        [HttpPost]
        public IHttpActionResult Token(LoginModel loginModel)
        {  
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            //string token = new AuthinticationManager().Authinticate(loginModel);
            string token = new TokenManager().GenerateToken(loginModel);
            Response.Result = true;
            Response.Message = token;
            return Ok(Response);
        }

        [AuthinticationManager]
        [Route("Api/Fms/Validate")]
        [HttpPost]
        public IHttpActionResult Validate()
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            return Ok((true, HttpStatusCode.OK));
        }


        [Route("Api/Fms/LoginBackOffice")]
        [HttpPost]
        public IHttpActionResult LoginBackOffice(LoginModel login)
        {
            // check if the user Exists 
            bool result = loginOperationsObject.LoginBackOffice(login);
            

            if (result == true)
            {
                string role = loginOperationsObject.GetUserRole(login);
                login.Role = role;
                return Token(login);
            }
            else
            {
                Response.Result = false;
                Response.Message = "Login failed";
                return Ok(Response);
            }

        }
        
        [Route("Api/Fms/BackOfficeAccountStatus")]
        [HttpPost]
        public IHttpActionResult BackOfficeAccountStatus(LoginModel login)
        {
            Response.Result = loginOperationsObject.GetCompanyEmployeeAccountStatus(login);

            if (Response.Result == true)
            {
                Response.Message = "Active";
            }
            else
            {
                Response.Message = "Not Active"; 
            }
            return Ok(Response);

        }

        [Route("Api/Fms/BackOfficeUpdatePasswordAndStatus")]
        [HttpPost]
        public IHttpActionResult BackOfficeUpdatePasswordAndStatus(UpdatePasswordModel login)
        {
            Response.Result = loginOperationsObject.UpdateBackOfficeAccountPasswordAndStatus(login);

            if (Response.Result == true)
            {
                Response.Message = "Active";
            }
            else
            {
                Response.Message = "Not Active";
            }
            return Ok(Response);

        }




        [Route("Api/Fms/LoginPortal")]
        [HttpPost]
        public IHttpActionResult LoginPortal(LoginModel login)
        {
            // check if the user Exists 
            bool result = loginOperationsObject.LoginPortal(login);
            bool status = loginOperationsObject.GetBeneficiaryAccountStatus(login);

            if (result == true && status == true)
            {
                string role = loginOperationsObject.GetUserRole(login);
                login.Role = role;
                return Token(login);
            }
            else
            {
                Response.Result = false;
                Response.Message = "Login failed";
                return Ok(Response);
            }

        }

        [Route("Api/Fms/BeneficiaryRegistraion")]
        [HttpPost]
        public IHttpActionResult BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            
            bool result = loginOperationsObject.BeneficiaryRegistraion(BeneficiaryRegistraion);

            if (result == true)
            {
                Response.Result = true;
                Response.Message = "Beneficiary has been successfully registered";
            }
            else
            {
                Response.Result = false;
                Response.Message = "Registration failed";
            }
                return Ok(Response);
        }

        [Route("Api/Fms/EmployeeRegistraion")]
        [HttpPost]
        public IHttpActionResult EmployeeRegistraion(EmployeeRegistraionModel EmployeeRegistraion)
        {

            bool result = loginOperationsObject.EmployeeRegistraion(EmployeeRegistraion);

            if (result == true)
            {
                Response.Result = true;
                Response.Message = "Employee has been successfully registered";
            }
            else
            {
                Response.Result = false;
                Response.Message = "Registration failed";
            }
                return Ok(Response);
        }

        [Route("Api/Fms/GetBuildingList")]
        [HttpGet]
        public IHttpActionResult GetBuildingList()
        {
            var BuildingList = loginOperationsObject.GetBuildingList();
            return Ok(BuildingList);
        }
        [Route("Api/Fms/GetSpecializationList")]
        [HttpGet]
        public IHttpActionResult GetSpecializationList()
        {
            List<SP_GetAllSpecializations_Result> SpecializationList = loginOperationsObject.GetSpecializationList();
            return Ok(SpecializationList);
        }
        [Route("Api/Fms/GetManagerList")]
        [HttpGet]
        public IHttpActionResult GetManagerList()
        {
            var ManagerList = loginOperationsObject.GetManagerList();

            return Ok(ManagerList);
        }
        [Route("Api/Fms/GetLocationList")]
        [HttpGet]
        public IHttpActionResult GetLocationList()
        {
            var Locations = loginOperationsObject.GetLocationList();

            return Ok(Locations);
        }
        [Route("Api/Fms/GetRoleList")]
        [HttpGet]
        public IHttpActionResult GetRoleList()
        {
            var Roles = loginOperationsObject.GetRoleList();
            return Ok(Roles);
        }


        [Route("Api/Fms/GetUserRole")]
        [HttpPost]
        public IHttpActionResult GetUserRole(LoginModel login)
        {
            Response.Message =  this.loginOperationsObject.GetUserRole(login);
            if (Response.Message != null)
                Response.Result = true;
            else
                Response.Result = false;
            return Ok(Response);
        }

        



    }
}
