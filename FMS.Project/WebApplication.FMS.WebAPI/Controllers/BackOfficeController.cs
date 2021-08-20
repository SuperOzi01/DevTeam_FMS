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
    [AuthinticationManager]
    public class BackOfficeController : ApiController
    {
        static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLog");
        static readonly ILog InfoLog = LogManager.GetLogger("InfoLog");
        ResponseAPI Response = new ResponseAPI();
        BackOfficeDatabaseOperations BackOfficeOperationsObject = new BackOfficeDatabaseOperations();


        [AuthorizationManager(Roles = "Maintenance Manager, Building Manager,Maintenance Worker")]
        [Route("API/BACKOFFICE/AcceptServiceRequest")]
        [HttpPost]
        public IHttpActionResult ChangeServiceRequestStatus(ServiceRequestAssignmentModel serviceModel)
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



        [AuthorizationManager(Roles = "Maintenance Manager")]
        [Route("API/BACKOFFICE/MMOpenRequests")]
        [HttpGet]
        public IHttpActionResult GetMMOpenRequestsList()
        {

            var response = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerOpenRequests();
            return Ok(response);
        }

        [AuthorizationManager(Roles = "Maintenance Manager")]
        [Route("API/BACKOFFICE/MMCloseRequests")]
        [HttpGet]
        public IHttpActionResult GetMMCloseRequestsList()
        {

            var response = BackOfficeOperationsObject.BackOfficeGetMaintananceManagerCloseRequests();
                return Ok(response);
        }
        [AuthorizationManager(Roles = "Maintenance Manager")]
        [Route("API/BACKOFFICE/MMApprovedRequests")]
        [HttpGet]
        public IHttpActionResult GetMMApprovedRequests()
        {
            var response = BackOfficeOperationsObject.BackOfficeMaintananceManagerApprovedRequests();
                return Ok(response);
        }

        [AuthorizationManager(Roles = "System Adminstrator, Maintenance Manager, Building Manager,Maintenance Worker")]
        [Route("API/BACKOFFICE/CanceledRequests")]
        [HttpGet]
        public IHttpActionResult GetAllCanceledRequests()
        {
            var response = BackOfficeOperationsObject.BackOfficeOverAllCanceledRequests();
                return Ok(response);
        }


        [AuthorizationManager(Roles = "Maintenance Manager, Building Manager")]
        [Route("API/BACKOFFICE/CancelRequest")]
        [HttpPost]
        public IHttpActionResult CancelRequest(ServiceRequestAssignmentModel request)
        {
            Response.Result = BackOfficeOperationsObject.Cancel_ServiceRequest(request.RequestID);
            if (Response.Result)
                Response.Message = "Request No. " + request.RequestID + " is Canceld.";
            else
                Response.Message = "Request No. " + request.RequestID + " Faced Error - Not Canceld.";
            return Ok(Response);
        }


        [AuthorizationManager(Roles = "System Adminstrator, Maintenance Manager, Building Manager,Maintenance Worker")]
        [Route("API/BACKOFFICE/GetRequestInfo")]
        [HttpPost]
        public IHttpActionResult GetRequestInfo(ServiceRequestAssignmentModel request)
        {
            var response = BackOfficeOperationsObject.GetServiceRequestInfo(request.RequestID);
                return Ok(response);
        }


        [AuthorizationManager(Roles = "System Adminstrator, Maintenance Manager")]
        [Route("API/BACKOFFICE/GetWorkersList")]
        [HttpPost]
        public IHttpActionResult GetWorkersList(ServiceRequestAssignmentModel request)
        {
            // the username here will contain the Service Request Type 
            var response = BackOfficeOperationsObject.GetWorkersListSpecializationBased(request.EmployeeUsername);
            return Ok(response);
        }


        [AuthorizationManager(Roles = "Maintenance Worker")]
        [Route("API/BACKOFFICE/WorkerOpenRequests")]
        [HttpPost]
        public IHttpActionResult GetWorkerOpenRequests(LoginModel login)
        {
            var response = BackOfficeOperationsObject.GetWorkerOpenedServiceRequests(login.Username);
                return Ok(response);
        }

        [AuthorizationManager(Roles = "Maintenance Worker")]
        [Route("API/BACKOFFICE/WorkerClosedRequests")]
        [HttpPost]
        public IHttpActionResult GetWorkerClosedRequests(LoginModel login)
        {
            var response = BackOfficeOperationsObject.GetWorkerClosedRequests(login.Username);
                return Ok(response);
        }


        [AuthorizationManager(Roles = "Building Manager")]
        [Route("API/BACKOFFICE/BuildingManagerOpenServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerOpenRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BackOfficeGetBuildingManagerOpenRequests(serviceRequest.BuildingID);
                return Ok(response);
        }

        [AuthorizationManager(Roles = "Building Manager")]
        [Route("API/BACKOFFICE/BuildingManagerClosedServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerClosedRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerClosedRequests(serviceRequest.BuildingID);
                return Ok(response);
        }
        [AuthorizationManager(Roles = "Building Manager")]
        [Route("API/BACKOFFICE/BuildingManagerCanceledServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerCanceledRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerCanceledRequests(serviceRequest.BuildingID);
                return Ok(response);
        }
        [AuthorizationManager(Roles = "Building Manager")]
        [Route("API/BACKOFFICE/BuildingManagerMM_ApprovedServiceRequests")]
        [HttpPost]
        public IHttpActionResult GetBuildingManagerMM_ApprovedRequests(ServiceRequestAssignmentModel serviceRequest)
        {
            var response = BackOfficeOperationsObject.BuildingManagerApprovedByMM_Requests(serviceRequest.BuildingID);
                return Ok(response);
        }

        [AuthorizationManager(Roles = "Building Manager")]
        [Route("API/BACKOFFICE/ManagerBuildingNo")]
        [HttpPost]
        public IHttpActionResult GetBuildingNumberOfManager(LoginModel user)
        {
            Response.Result = true;
            Response.Message = BackOfficeOperationsObject.GetBM_BuildingNumber(user.Username).ToString();
                return Ok(Response);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/ListOfNotActiveBeneficiaries")]
        [HttpGet]
        public IHttpActionResult GetNotActiveBeneficiariesList()
        {
            var result = BackOfficeOperationsObject.GetListOfNotActiveUseres();
            return Ok(result);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/NumberOfWorkers")]
        [HttpGet]
        public IHttpActionResult NumberOfWorkers()
        {
            var result = BackOfficeOperationsObject.NumberOfActiveWorkers();
            return Ok(result);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/NumberOfBeneficiaries")]
        [HttpGet]
        public IHttpActionResult NumberOfBeneficiaries()
        {
            var result = BackOfficeOperationsObject.NumberOfActiveBeneficiaries();
            return Ok(result);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/NumberOfOpenRequests")]
        [HttpGet]
        public IHttpActionResult NumberOfOpenRequests()
        {
            var result = BackOfficeOperationsObject.NumberOfOpenedRequests();
            return Ok(result);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/NumberOfClosedRequests")]
        [HttpGet]
        public IHttpActionResult NumberOfClosedRequests()
        {
            var result = BackOfficeOperationsObject.NumberOfClosedRequests();
            return Ok(result);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/ActivateBeneficiary")]
        [HttpPost]
        public IHttpActionResult ActivateBeneficiary(LoginModel userModel)
        {
           Response.Result =  BackOfficeOperationsObject.PortalActivateBeneficiaryAccount(userModel.Username);
            if (Response.Result)
                Response.Message = "Beneficiary Account Activated";
            else
                Response.Message = "Failed To Activate Beneficiary Account";
            return Ok(Response);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/GetAllCompanyEmployees")]
        [HttpGet]
        public IHttpActionResult GetAllCompanyEmployees()
        {
            List<SP_GetCompanyEmployeesList_Result> list = BackOfficeOperationsObject.ListOfCompanyEmployees();
            return Ok(list);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/GetBMList")]
        [HttpGet]
        public IHttpActionResult GetBMList()
        {
            List<SP_GetAllBuildingManagers_Result> list = BackOfficeOperationsObject.GetBMsList();
            return Ok(list);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/AddBuilding")]
        [HttpPost]
        public IHttpActionResult AddBuilding(BuildingModel building)
        {
            Response.Result = BackOfficeOperationsObject.AddNewBuilding(building);
            if (Response.Result == true)
                Response.Message = "Request Have Been Created";
            else
                Response.Message = "Request Failed";
            return Ok(Response);
        }

        [AuthorizationManager(Roles = "System Adminstrator")]
        [Route("API/BACKOFFICE/AddSpecialization")]
        [HttpPost]
        public IHttpActionResult AddSpecialization(SpecializationModel model)
        {
            Response.Result = BackOfficeOperationsObject.AddSpecialization(model);
            if (Response.Result == true)
                Response.Message = "Request Have Been Created";
            else
                Response.Message = "Request Failed";
            return Ok(Response);
        }


        [AuthorizationManager(Roles = "System Adminstrator, Maintenance Manager, Building Manager,Maintenance Worker")]
        [Route("API/BACKOFFICE/AuditTransaction")]
        [HttpPost]
        public IHttpActionResult AuditTransaction(TransactionModel transaction)
        {
            BackOfficeOperationsObject.MakeTransaction(transaction);
            Response.Result = true;
            Response.Message = "Request Have Been Created";
            return Ok(Response);
        }
    }
}
