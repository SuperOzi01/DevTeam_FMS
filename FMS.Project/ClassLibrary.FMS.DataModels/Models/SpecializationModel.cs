using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class SpecializationModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string SpecializationName { get; set; }
    }
}
