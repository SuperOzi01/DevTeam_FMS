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
    public class BackOfficeController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI Response = new ResponseAPI();
        BackOfficeDatabaseOperations BackOfficeOperationsObject = new BackOfficeDatabaseOperations();


        [Route("Api/Fms/BackOffice/ChangeServiceRequestStatus")]
        [HttpPost]
        public IHttpActionResult BackOfficeChangeServiceRequestStatus(ServiceRequestAssignmentModel serviceModel)
        {
            Response.Result = BackOfficeOperationsObject.BackOfficeChangeRequestStatus(serviceModel.EmployeeUsername, serviceModel.RequestID);

            if (Response.Result)
                Response.Message = "Request Status Changed";
            else
                Response.Message = "Request Status Not Changed";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/AssignWorkerToRequest")]
        [HttpPost]
        public IHttpActionResult BackOfficeAssignWorkerToRequest(ServiceRequestAssignmentModel serviceModel)
        {
            Response.Result = BackOfficeOperationsObject.BackOfficeAssignWorkerToRequest(serviceModel.MaintenanceWorkerID, serviceModel.RequestID);

            if (Response.Result)
                Response.Message = "Worker Been Assigned";
            else
                Response.Message = "Worker Not Assigned";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/MMOpenRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMOpenRequestsList()
        {

            List<SP_GetMMOpenRequests_Result> RequestsList = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerOpenRequests();
            
            return Ok(RequestsList);
        }

        [Route("Api/Fms/BackOffice/MMCloseRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMCloseRequestsList()
        {

            List<SP_GetMMClosedRequests_Result> RequestsList = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerCloseRequests();

            return Ok(RequestsList);
        }

        [Route("Api/Fms/BackOffice/MMApprovedRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMApprovedRequests()
        {
            var ApprovedList = BackOfficeOperationsObject.BackOfficeMaintananceManagerApprovedRequests();
            return Ok(ApprovedList);
        }

        [Route("Api/Fms/BackOffice/CanceledRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeCanceledRequests()
        {
            var CanceledList = BackOfficeOperationsObject.BackOfficeOverAllCanceledRequests();
            return Ok(CanceledList);
        }

        [Route("Api/Fms/BackOffice/CancelRequest")]
        [HttpPost]
        public IHttpActionResult BackOfficeCancelRequest(ServiceRequestAssignmentModel request)
        {
            Response.Result = BackOfficeOperationsObject.Cancel_ServiceRequest(request.RequestID);
            if (Response.Result)
                Response.Message = "Request No. " + request.RequestID + " is Canceld.";
            else
                Response.Message = "Request No. " + request.RequestID + " Faced Error - Not Canceld.";
            return Ok(Response);
        }


    }
}
