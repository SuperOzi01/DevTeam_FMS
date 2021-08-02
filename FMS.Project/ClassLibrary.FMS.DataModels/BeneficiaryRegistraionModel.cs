using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels
{
    public class BeneficiaryRegistraionModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int BuildingID { get; set; }
        public int RoleID { get; set; }
    }
}
