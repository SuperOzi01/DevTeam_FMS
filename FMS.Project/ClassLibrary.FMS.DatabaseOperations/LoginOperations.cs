using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.FMS.DataModels; 
namespace ClassLibrary.FMS.DatabaseOperations
{
    class LoginOperations
    {
        FMS_DatabaseEntities DatabaseEntity = new FMS_DatabaseEntities();
        public bool Login(string username, string password)
        {
            int result = DatabaseEntity; 
            return true; 
        }
    }
}
