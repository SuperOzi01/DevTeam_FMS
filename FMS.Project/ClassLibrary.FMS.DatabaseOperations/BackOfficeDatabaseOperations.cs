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
            List<ServiceRequest> BuildingManagerRequestsList = (List<ServiceRequest>)DatabaseEntity.ServiceRequests.Where(x => x.RequiestStatus == 1).Select(a => a).ToList();
            return BuildingManagerRequestsList;
        }

        public List<ServiceRequest> BackOfficeGetWorkerOpenRequests(string workerUsername)
        {
            int workerID = DatabaseEntity.CompanyEmployees.Where(x => x.Username == workerUsername).Select(a => a.EmployeeID).FirstOrDefault();
            List<ServiceRequest> WorkerRequestsList = (List<ServiceRequest>)DatabaseEntity.ServiceRequests.Where(x => x.AssignedWorkerID == workerID && x.RequiestStatus == 3).Select(a => a).ToList();
            return WorkerRequestsList;
        }
    }
}
