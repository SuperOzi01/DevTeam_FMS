using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class ServiceRequestAssignmentModel
    {
        public string EmployeeUsername { get; set; }
        public int MaintenanceWorkerID { get; set; }
        public int RequestID { get; set; }
    }
}
