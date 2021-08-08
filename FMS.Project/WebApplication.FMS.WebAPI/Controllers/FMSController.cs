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

        [Route("Api/Fms/ping")] 
        [HttpGet]
        [ExceptionFilter]
        public IHttpActionResult Ping()
        {
            // test the api logs and exceptions   
            //throw new DivideByZeroException();
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
            // 3- Logs 
            Response.Message = "Health Check is Working";
            Response.Result = true;
            return Ok(Response);
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
            var SpecializationList = loginOperationsObject.GetSpecializationList();

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
            var ManagerList = loginOperationsObject.GetManagerList();

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
            var BuildingList = loginOperationsObject.GetLocationList();

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
            var BuildingList = loginOperationsObject.GetRoleList();

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
