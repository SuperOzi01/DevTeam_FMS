using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DatabaseOperations
{
    public class BackOfficeDatabaseOperations
    {
        FMS_DatabaseEntities DatabaseEntity = new FMS_DatabaseEntities();
        public bool AcceptRequestAndAssignWorker(ServiceRequestAssignmentModel serviceRequestAssignment)
        {
            var result = DatabaseEntity.SP_ChangeServiceRequestStatus(serviceRequestAssignment.EmployeeUsername, serviceRequestAssignment.RequestID).FirstOrDefault();
            if (result == 1)
            {
                if(serviceRequestAssignment.MaintenanceWorkerID == 0)
                {
                    return true;
                }
                    result = DatabaseEntity.SP_AssignWorkerToRequest(serviceRequestAssignment.MaintenanceWorkerID, serviceRequestAssignment.RequestID);
                if (result == 1)
                    return true;
                return false;
            }
            
            return false;
        }


        public List<SP_GetMMOpenRequests_Result> BackOfficeGetMaintananceManagerOpenRequests()
        {
            
            List<SP_GetMMOpenRequests_Result> MaintananceManagerRequestsList = DatabaseEntity.SP_GetMMOpenRequests().ToList();
            return MaintananceManagerRequestsList;
        }

        public List<ServiceRequest> BackOfficeGetBuildingManagerOpenRequests()
        {
            List<ServiceRequest> BuildingManagerRequestsList = DatabaseEntity.ServiceRequests.Where(x => x.RequiestStatus == 1).Select(a => a).ToList();
            return BuildingManagerRequestsList;
        }


        public List<SP_GetMMClosedRequests_Result> BackOfficeGetMaintananceManagerCloseRequests()
        {
            return DatabaseEntity.SP_GetMMClosedRequests().ToList();
        }

        public List<SP_GetMMApprovedRequests_Result> BackOfficeMaintananceManagerApprovedRequests()
        {
            return DatabaseEntity.SP_GetMMApprovedRequests().ToList();
        }
        public List<SP_GetAllCanceledRequests_Result> BackOfficeOverAllCanceledRequests()
        {
            return DatabaseEntity.SP_GetAllCanceledRequests().ToList();
        }

        public bool Cancel_ServiceRequest(int RequestID)
        {
            int result = (int) DatabaseEntity.SP_Cancel_OpenedServiceRequest(RequestID).FirstOrDefault();
            if(result == 1)
                return true;
            return false;
        }

        public SP_GetSpecificServiceRequestInfo_Result GetServiceRequestInfo(int RequestID)
        {
            return DatabaseEntity.SP_GetSpecificServiceRequestInfo(RequestID).FirstOrDefault();
        }

        public List<SP_GetWorkersOfSpecialization_Result> GetWorkersListSpecializationBased(string SpecializationName)
        {
            return DatabaseEntity.SP_GetWorkersOfSpecialization(SpecializationName).ToList();
        }

        public List<SP_GetWorkerOpenRequests_Result> GetWorkerOpenedServiceRequests(string Username)
        {
            return DatabaseEntity.SP_GetWorkerOpenRequests(Username).ToList();
        }

        public List<SP_GetWorkerClosedRequests_Result> GetWorkerClosedRequests(string username)
        {
            return DatabaseEntity.SP_GetWorkerClosedRequests(username).ToList();
        }
    }
}
