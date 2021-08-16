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
    public class PortalSystemController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI Response = new ResponseAPI();
        private PortalSystemOperations OperationsObject = new PortalSystemOperations();

        [Route("API/PORTALSYSTEM/CreateRequest")]
        [HttpPost]
        public IHttpActionResult CreateNewRequest(NewServiceRequestModel serviceRequest)
        {
            Response.Result = OperationsObject.CreateNewServiceRequest(serviceRequest);
            if (Response.Result == true)
                Response.Message = "Request Have Been Created";
            else
                Response.Message = "Request Failed";
            return Ok(Response);
        }

        [Route("API/PORTALSYSTEM/GetRequestInfo")]
        [HttpPost]
        public IHttpActionResult GetRequestInfo(ServiceRequestAssignmentModel request)
        {
            var response = OperationsObject.GetServiceRequestInfo(request.RequestID);
            return Ok(response);
        }

        [Route("API/PORTALSYSTEM/OpenRequests")]
        [HttpPost]
        public IHttpActionResult OpenRequests(LoginModel login)
        {
            var result = OperationsObject.GetBeneficiaryOpenRequests(login.Username);
            return Ok(result);
        }

        [Route("API/PORTALSYSTEM/ClosedRequests")]
        [HttpPost]
        public IHttpActionResult ClosedRequests(LoginModel login)
        {
            var result = OperationsObject.GetBeneficiaryClosedRequests(login.Username);
            return Ok(result);
        }

        [Route("API/PORTALSYSTEM/CanceledRequests")]
        [HttpPost]
        public IHttpActionResult CanceledRequests(LoginModel login)
        {
            var result = OperationsObject.GetBeneficiaryCanceledRequests(login.Username);
            return Ok(result);
        }

        [Route("API/PORTALSYSTEM/BeneficiaryBuilding")]
        [HttpPost]
        public IHttpActionResult BeneficiaryBuildingNo(LoginModel user)
        {
            int result = OperationsObject.GetBeneficiaryBuildingNumber(user.Username);
            Response.Message = result.ToString();
            if (result != 0)
                Response.Result = true;
            else
                Response.Result = false;
            return Ok(Response);
        }
    }
}
