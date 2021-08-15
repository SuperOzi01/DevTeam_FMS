using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class ServiceRequestAssignmentModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string EmployeeUsername { get; set; }
        public int MaintenanceWorkerID { get; set; }
        public int RequestID { get; set; }
        public int BuildingID { get; set; }
    }
}
