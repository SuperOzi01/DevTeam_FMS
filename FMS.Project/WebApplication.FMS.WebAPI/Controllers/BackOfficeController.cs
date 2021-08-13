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


        [Route("Api/Fms/BackOffice/AcceptServiceRequest")]
        [HttpPost]
        public IHttpActionResult BackOfficeChangeServiceRequestStatus(ServiceRequestAssignmentModel serviceModel)
        {
            Response.Result = BackOfficeOperationsObject.AcceptRequestAndAssignWorker(serviceModel);
            if (Response.Result)
            {
                Response.Message = "Request Status Changed";
            }
            else
                Response.Message = "Request Status Not Changed";
            return Ok(Response);
        }


        [Route("Api/Fms/BackOffice/MMOpenRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMOpenRequestsList()
        {

            var response = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerOpenRequests();
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/MMCloseRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMCloseRequestsList()
        {

            var response = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerCloseRequests();
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/MMApprovedRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeGetMMApprovedRequests()
        {
            var response = BackOfficeOperationsObject.BackOfficeMaintananceManagerApprovedRequests();
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/CanceledRequests")]
        [HttpGet]
        public IHttpActionResult BackOfficeCanceledRequests()
        {
            var response = BackOfficeOperationsObject.BackOfficeOverAllCanceledRequests();
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
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

        [Route("Api/Fms/BackOffice/GetRequestInfo")]
        [HttpPost]
        public IHttpActionResult GetRequestInfo(ServiceRequestAssignmentModel request)
        {
            var response = BackOfficeOperationsObject.GetServiceRequestInfo(request.RequestID);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/GetWorkersList")]
        [HttpPost]
        public IHttpActionResult GetWorkersList(ServiceRequestAssignmentModel request)
        {
            // the username here will contain the Service Request Type 
            var response = BackOfficeOperationsObject.GetWorkersListSpecializationBased(request.EmployeeUsername);
            if(response != null)
            return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/WorkerOpenRequests")]
        [HttpPost]
        public IHttpActionResult GetWorkerOpenRequests(LoginModel login)
        {
            var response = BackOfficeOperationsObject.GetWorkerOpenedServiceRequests(login.Username);
            if(response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/WorkerClosedRequests")]
        [HttpPost]
        public IHttpActionResult GetWorkerClosedRequests(LoginModel login)
        {
            var response = BackOfficeOperationsObject.GetWorkerClosedRequests(login.Username);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/BuildingManagerOpenServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerOpenRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BackOfficeGetBuildingManagerOpenRequests(serviceRequest.BuildingID);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }


        [Route("Api/Fms/BackOffice/BuildingManagerClosedServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerClosedRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerClosedRequests(serviceRequest.BuildingID);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/BuildingManagerCanceledServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerCanceledRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerCanceledRequests(serviceRequest.BuildingID);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/BuildingManagerMM_ApprovedServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerMM_ApprovedRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerApprovedByMM_Requests(serviceRequest.BuildingID);
            if (response != null)
                return Ok(response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/ManagerBuildingNo")]
        [HttpPost]
        public IHttpActionResult GetBuildingNumberOfManager(LoginModel user)
        {
            Response.Result = true;
            Response.Message = BackOfficeOperationsObject.GetBM_BuildingNumber(user.Username).ToString();
            if (Response.Message != null)
                return Ok(Response);
            Response.Result = false;
            Response.Message = "The Result Of This Request Was Empty";
            return Ok(Response);
        }

        [Route("Api/Fms/BackOffice/ListOfNotActiveBeneficiaries")]
        [HttpGet]
        public IHttpActionResult GetNotActiveBeneficiariesList()
        {
            var result = BackOfficeOperationsObject.GetListOfNotActiveUseres();
            return Ok(result);
        }

        [Route("Api/Fms/BackOffice/NumberOfWorkers")]
        [HttpGet]
        public IHttpActionResult NumberOfWorkers()
        {
            var result = BackOfficeOperationsObject.NumberOfActiveWorkers();
            return Ok(result);
        }

        [Route("Api/Fms/BackOffice/NumberOfBeneficiaries")]
        [HttpGet]
        public IHttpActionResult NumberOfBeneficiaries()
        {
            var result = BackOfficeOperationsObject.NumberOfActiveBeneficiaries();
            return Ok(result);
        }

        [Route("Api/Fms/BackOffice/NumberOfOpenRequests")]
        [HttpGet]
        public IHttpActionResult NumberOfOpenRequests()
        {
            var result = BackOfficeOperationsObject.NumberOfOpenedRequests();
            return Ok(result);
        }

        [Route("Api/Fms/BackOffice/NumberOfClosedRequests")]
        [HttpGet]
        public IHttpActionResult NumberOfClosedRequests()
        {
            var result = BackOfficeOperationsObject.NumberOfClosedRequests();
            return Ok(result);
        }



    }
}
