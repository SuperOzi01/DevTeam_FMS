using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class RequestInfoModel
    {
        public SP_GetSpecificServiceRequestInfo_Result ReqInfo { get; set; }
        public List<SP_GetWorkersOfSpecialization_Result> WorkersList { get; set; }
    }
}
