using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public class EncryptionModel
    {
       
        public string EncryptPassword(string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] encByts = sha256Hash.ComputeHash(Encoding.ASCII.GetBytes(password));
            StringBuilder EncryptedPass = new StringBuilder();
            foreach(byte letter in encByts)
            {
                EncryptedPass.Append(letter.ToString("x2"));
            }
            return EncryptedPass.ToString().Substring(0,40);
        }



    }
}
