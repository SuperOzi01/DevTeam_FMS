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
using ClassLibrary.FMS.DataModels.Constants.ConstantStrings;

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

        [Route("API/FMS/PING")] 
        [HttpGet]
        public IHttpActionResult Ping()
        {
           
            // test the api logs and exceptions   
            Response.Message = "Ping is Working";
            Response.Result = true;
            return Ok(Response);
        }

        [Route("API/FMS/HelthCheck")]
        [HttpGet]
        public IHttpActionResult HelthCheck()
        {
            // Here We Should ensure that: 
            
            // 1- DB connection 
            int result = loginOperationsObject.TestDB();
            // 2- Logs
            throw new DivideByZeroException();
        }

        [Route("API/FMS/Token")]
        [HttpPost]
        public IHttpActionResult Token(LoginModel loginModel)
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            //string token = new AuthinticationManager().Authinticate(loginModel);
            loginModel.Role = loginOperationsObject.GetUserRole(loginModel);
            string token = new TokenManager().GenerateToken(loginModel);
            Response.Result = true;
            Response.Message = token;
            return Ok(Response);
        }

        [AuthinticationManager]
        [Route("API/FMS/Validate")]
        [HttpPost]
        public IHttpActionResult Validate()
        {
            // This Function Shall recieve User Model Object .. and return the token as a result.. 
            return Ok(this.Request.CreateResponse(HttpStatusCode.OK, "Validated"));
        }

        
        [Route("API/FMS/LoginBackOffice")]
        [HttpPost]
        public IHttpActionResult LoginBackOffice(LoginModel login)
        {
            // check if the user Exists 
            bool result = loginOperationsObject.LoginBackOffice(login);
            

            if (result == true)
            {
                return Token(login);
            }
            else
            {
                Response.Result = false;
                Response.Message = "Login failed";
                return Ok(Response);
            }

        }
        
        
        [Route("API/FMS/BackOfficeAccountStatus")]
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

        [Route("API/FMS/BackOfficeUpdatePasswordAndStatus")]
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




        [Route("API/FMS/LoginPortal")]
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

        [Route("API/FMS/BeneficiaryRegistraion")]
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

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/FMS/EmployeeRegistraion")]
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

        [Route("API/FMS/GetBuildingList")]
        [HttpGet]
        public IHttpActionResult GetBuildingList()
        {
            List<SP_GetAllBuildings_Result> BuildingList = loginOperationsObject.GetBuildingList();
            return Ok(BuildingList);
        }
        [Route("API/FMS/GetSpecializationList")]
        [HttpGet]
        public IHttpActionResult GetSpecializationList()
        {
            List<SP_GetAllSpecializations_Result> SpecializationList = loginOperationsObject.GetSpecializationList();
            return Ok(SpecializationList);
        }

        [Route("API/FMS/GetManagerList")]
        [HttpGet]
        public IHttpActionResult GetManagerList()
        {
            List<SP_MaintananceManagersList_Result> ManagerList = loginOperationsObject.GetManagerList();

            return Ok(ManagerList);
        }
        [Route("API/FMS/GetLocationList")]
        [HttpGet]
        public IHttpActionResult GetLocationList()
        {
            List<SP_GetAllLocations_Result> Locations = loginOperationsObject.GetLocationList();

            return Ok(Locations);
        }
        [Route("API/FMS/GetRoleList")]
        [HttpGet]
        public IHttpActionResult GetRoleList()
        {
            List<SP_GetAllRoles_Result> Roles = loginOperationsObject.GetRoleList();
            return Ok(Roles);
        }


        [Route("API/FMS/GetUserRole")]
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
