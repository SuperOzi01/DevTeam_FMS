using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class NotActiveUsersOfBuildingModel
    {
        public int BuildingNumber { get; set; }
        public List<SP_ListOfNotActiveBeneficiaries_Result> BeneficiariesList { get; set; }
    }
}
