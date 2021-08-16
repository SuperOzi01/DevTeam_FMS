using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class BMRequistsInfo
    {
        public int ServiceRequestID { get; set; }
        public int BuildingID { get; set; }
        public string Specialization_Type { get; set; }
        public System.DateTime RequestIssueDate { get; set; }
        public string ServiceDescribtion { get; set; }
        public string Request_Creator { get; set; }
    }
}
