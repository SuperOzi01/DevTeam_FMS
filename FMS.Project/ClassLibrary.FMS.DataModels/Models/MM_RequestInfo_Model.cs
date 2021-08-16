using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class MM_RequestInfo_Model
    {
        public SP_GetSpecificServiceRequestInfo_Result RequestInfo { set; get; }
        public List<SP_GetWorkersOfSpecialization_Result> WorkersList { set; get; }

    }
}
