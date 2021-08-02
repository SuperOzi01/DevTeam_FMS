using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels
{
    public class EmployeeRegistraionModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int SpecializationID  { get; set; }
        public int ? ManagerID  { get; set; }
        public int LocationID { get; set; }
        public int RoleID { get; set; }
    }
}
