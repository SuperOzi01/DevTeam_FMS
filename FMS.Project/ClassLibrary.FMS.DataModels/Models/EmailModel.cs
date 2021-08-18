using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class EmailModel
    {
        public string Subject { get; set; }
        public string Body {get; set;}
        public string ToEmail { get; set; }

    }
}
