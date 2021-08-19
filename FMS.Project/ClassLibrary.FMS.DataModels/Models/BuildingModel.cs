using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class BuildingModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string BuildingID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string NoFloors { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Ownership { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int BMID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int LocationID { get; set; }
         
    }
}
