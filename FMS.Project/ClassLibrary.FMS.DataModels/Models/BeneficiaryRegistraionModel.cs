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
        [StringLength(maximumLength:20,MinimumLength =8 , ErrorMessage ="The Password Should Be Between 8 - 20 Characters")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage ="The Password Should Contain Small and Capital Letters and Symbols")]
        public string Password { get; set; }
        
        
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Building Number")]
        public int BuildingID { get; set; }


    }
}
