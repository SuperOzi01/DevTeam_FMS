using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class UpdatePasswordModel
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "The Password Should Be Between 8 - 20 Characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "The Password Should Be Between 8 - 20 Characters")]
        [Display (Name ="Re-Enter Password")]
        public string RePassword { get; set; }
    }
}
