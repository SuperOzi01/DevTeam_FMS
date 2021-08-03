using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels
{
    public class BeneficiaryRegistraionModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Building Number")]
        public int BuildingID { get; set; }
    }
}
