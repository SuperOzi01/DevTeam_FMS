using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace WebApplication.FMS.WebAPI.App_Start
{
    public class TokenManager
    {
        //private static string Secret = "ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";
        private const string secretKey = "This is the Secrit Key";
        public static string GenerateToken()
        {
           // Book_StoreEntities Con = new Book_StoreEntities();
            //var nameRole = Con.RoleName(id).ToList();
            byte[] key = Encoding.ASCII.GetBytes(secretKey);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);

            List<Claim> claims = new List<Claim>();
            //foreach (var item in nameRole)
            //{
             //   claims.Add(new Claim(ClaimTypes.Role, item));
            //}

            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(securityKey,
                SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }
    }
}