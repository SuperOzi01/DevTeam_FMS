using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class BuildingModel
    {
        public string BuildingID { get; set; }
        public string NoFloors { get; set; }
        public int Ownership { get; set; }
        public int BMID { get; set; }
        public int LocationID { get; set; }
         
    }
}
