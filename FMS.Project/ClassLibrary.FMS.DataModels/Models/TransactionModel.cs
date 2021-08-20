using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class TransactionModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string TransactionMakerUsername { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int ServiceRequestID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public bool Decision { get; set; }
    }
}
