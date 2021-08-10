using ClassLibrary.FMS.DataModels;
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
        public bool BackOfficeChangeRequestStatus(string EmployeeUserName, int RequestID)
        {
            var result = DatabaseEntity.SP_ChangeServiceRequestStatus(EmployeeUserName, RequestID);
            if (result.FirstOrDefault() == 1)
                return true;
            return false;
        }

        public bool BackOfficeAssignWorkerToRequest(int WorkerID, int RequestID)
        {
            int result = DatabaseEntity.SP_AssignWorkerToRequest(WorkerID, RequestID);
            if (result == 1)
                return true;
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

        public List<ServiceRequest> BackOfficeGetWorkerOpenRequests(string workerUsername)
        {
            int workerID = DatabaseEntity.CompanyEmployees.Where(x => x.Username == workerUsername).Select(a => a.EmployeeID).FirstOrDefault();
            List<ServiceRequest> WorkerRequestsList = (List<ServiceRequest>)DatabaseEntity.ServiceRequests.Where(x => x.AssignedWorkerID == workerID && x.RequiestStatus == 3).Select(a => a).ToList();
            return WorkerRequestsList;
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

    }
}
