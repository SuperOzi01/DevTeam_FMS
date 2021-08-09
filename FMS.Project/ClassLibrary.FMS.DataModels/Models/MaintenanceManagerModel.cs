using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class MaintenanceManagerModel
    {
        public List<SP_GetMMOpenRequests_Result> OpenRequests { get; set;}
        public List<SP_GetMMClosedRequests_Result> ClosedRequests { get; set; }
        public List<SP_GetMMApprovedRequests_Result> ApprovedRequests { get; set; }
        public List<SP_CanceledServiceRequests_Result> CanceledRequests { get; set; }
    }
}
