using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels
{
    class LoginModel
    {
        [Display (Name = "Username")]
        public string Username { get; set; }

        [Display (Name = "Password")]
        [StringLength(1000, MinimumLength = 8, ErrorMessage = "field must be atleast 8 characters")]
        public string Password { get; set; }
    }
}
