using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassLibrary.FMS.DataModels
{
    public class WebCookies
    {
        public HttpCookie CreateCookie(string name, string value)
        {
            HttpCookie StudentCookies = new HttpCookie(name);
            StudentCookies.Value = value;
            StudentCookies.Expires = DateTime.Now.AddHours(1);
            return StudentCookies;
        }
    }
}
