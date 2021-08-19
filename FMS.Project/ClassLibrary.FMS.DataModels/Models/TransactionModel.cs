using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class TransactionModel
    {
        //[Required]
        public int TransactionMakerID { get; set; }
        public int ServiceRequestID { get; set; }
        public bool Decision { get; set; }
    }
}
