using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DatabaseOperations
{
    public class PortalSystemOperations
    {
        FMS_DatabaseEntities DatabaseEntity = new FMS_DatabaseEntities();

        public List<SP_GetBeneficiaryOpenRequests_Result> GetBeneficiaryOpenRequests(string username)
        {
            return DatabaseEntity.SP_GetBeneficiaryOpenRequests(username).ToList();
        }

        public List<SP_GetBeneficiaryCloseedRequest_Result> GetBeneficiaryClosedRequests(string username)
        {
            return DatabaseEntity.SP_GetBeneficiaryCloseedRequest(username).ToList();
        }

        public List<SP_GetBeneficiaryCanceledRequests_Result> GetBeneficiaryCanceledRequests(string username)
        {
            return DatabaseEntity.SP_GetBeneficiaryCanceledRequests(username).ToList();
        }

        public bool CreateNewServiceRequest(NewServiceRequestModel serviceRequest)
        {
            int result = (Int32) DatabaseEntity.SP_InsertNewServiceRequiest(buildinNo: serviceRequest.BuildingID, specialization: serviceRequest.SpecializationID, describtion: serviceRequest.Describtion, creatorUsername: serviceRequest.CreatorUsername).FirstOrDefault();
            if (result == 1)
                return true;
            else
                return false;
        }

        public int GetBeneficiaryBuildingNumber(string username)
        {
           int building = DatabaseEntity.Beneficiaries.Where(x => x.Username == username).Select(a => a.Building_BuildingID).FirstOrDefault();
           return building;
        }

    }
}
