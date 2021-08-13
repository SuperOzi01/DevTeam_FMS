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
       
        /// Maintenance Manager 

        public List<SP_GetMMOpenRequests_Result> BackOfficeGetMaintananceManagerOpenRequests()
        {
            
            List<SP_GetMMOpenRequests_Result> MaintananceManagerRequestsList = DatabaseEntity.SP_GetMMOpenRequests().ToList();
            return MaintananceManagerRequestsList;
        }


        public List<SP_GetMMApprovedRequests_Result> BackOfficeMaintananceManagerApprovedRequests()
        {
            return DatabaseEntity.SP_GetMMApprovedRequests().ToList();
        }


        public List<SP_GetAllCanceledRequests_Result> BackOfficeOverAllCanceledRequests()
        {
            return DatabaseEntity.SP_GetAllCanceledRequests().ToList();
        }


        public List<SP_GetMMClosedRequests_Result> BackOfficeGetMaintananceManagerCloseRequests()
        {
            return DatabaseEntity.SP_GetMMClosedRequests().ToList();
        }

        /// Building Manager 

        public List<SP_GetBMOpenedRequests_Result> BackOfficeGetBuildingManagerOpenRequests(int BuildingID)
        {
                List<SP_GetBMOpenedRequests_Result> BuildingManagerRequestsList = DatabaseEntity.SP_GetBMOpenedRequests(BuildingID).ToList();
                return BuildingManagerRequestsList;
        }

        public List<SP_GetBMClosedRequests_Result> BuildingManagerClosedRequests(int BuildingID)
        {
            return DatabaseEntity.SP_GetBMClosedRequests(BuildingID).ToList();
        }

        public List<SP_GetBMCanceledRequests_Result> BuildingManagerCanceledRequests(int BuildingID)
        {
            return DatabaseEntity.SP_GetBMCanceledRequests(BuildingID).ToList();
        }

        public List<SP_GetBM_MM_ApprovedRequesets_Result> BuildingManagerApprovedByMM_Requests(int BuildingID)
        {
            return DatabaseEntity.SP_GetBM_MM_ApprovedRequesets(BuildingID).ToList();
        }

        public int GetBM_BuildingNumber(string ManagerUsername)
        {
            int ManagerID = DatabaseEntity.CompanyEmployees.Where(x => x.Username == ManagerUsername).Select(a => a.EmployeeID).FirstOrDefault();
            return DatabaseEntity.Buildings.Where(x => x.BuildingManagerID == ManagerID).Select(a => a.BuildingID).FirstOrDefault();
        }

        // Maintanance Worker
        public List<SP_GetWorkerOpenRequests_Result> GetWorkerOpenedServiceRequests(string Username)
        {
            return DatabaseEntity.SP_GetWorkerOpenRequests(Username).ToList();
        }

        public List<SP_GetWorkerClosedRequests_Result> GetWorkerClosedRequests(string username)
        {
            return DatabaseEntity.SP_GetWorkerClosedRequests(username).ToList();
        }


        // General Use Functions 
        public bool AcceptRequestAndAssignWorker(ServiceRequestAssignmentModel serviceRequestAssignment)
        {
            var result = DatabaseEntity.SP_ChangeServiceRequestStatus(serviceRequestAssignment.MaintenanceWorkerID, serviceRequestAssignment.RequestID).FirstOrDefault();
            if (result == 1)
            {
                if (serviceRequestAssignment.MaintenanceWorkerID == 0)
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

        
       //////////////////////////////////////  System Admin  //////////////////////////////////////////
       public List<NotActiveUsersOfBuildingModel> GetListOfNotActiveUseres()
        {
            List<NotActiveUsersOfBuildingModel> result = new List<NotActiveUsersOfBuildingModel>();
            List<int> BuildingIDs = DatabaseEntity.Buildings.Select(a => a.BuildingID).ToList();

            foreach(int item in BuildingIDs)
            {
                List<SP_ListOfNotActiveBeneficiaries_Result> Beneficiaries = DatabaseEntity.SP_ListOfNotActiveBeneficiaries(item).ToList();
                result.Add( new NotActiveUsersOfBuildingModel() { BuildingNumber = item, BeneficiariesList = Beneficiaries }); 
            }
            return result;

        }

        public int NumberOfActiveBeneficiaries()
        {
            return (int) DatabaseEntity.SP_GetNumberOfBeneficiaries().First();
        }

        public int NumberOfActiveWorkers()
        {
            return (int) DatabaseEntity.SP_GetWorkersNumber().First();
        }

        public int NumberOfClosedRequests()
        {
            return (int)DatabaseEntity.SP_GetNumberOfClosedRequests().First();
        }

        public int NumberOfOpenedRequests()
        {
            return (int) DatabaseEntity.SP_GetNumberOfOpenedRequests().First();
        }

    }
}
