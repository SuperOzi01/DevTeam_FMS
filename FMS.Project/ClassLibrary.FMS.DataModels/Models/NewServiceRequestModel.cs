using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class NewServiceRequestModel
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Building Number")]
        public int BuildingID { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Service Type")]
        public int SpecializationID { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Problem Describtion")]
        public string Describtion { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Building Number")]
        public string CreatorUsername { get; set; }
    }
}
