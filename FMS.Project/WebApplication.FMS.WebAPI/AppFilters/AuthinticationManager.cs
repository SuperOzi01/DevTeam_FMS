using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication.FMS.WebAPI.AppFilters
{
    public class AuthinticationManager : AuthorizationFilterAttribute
    {
        private const string secretKey = "This is the Secrit Key ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";


        public string Authinticate(string username)
        {

            
            // this can be undone if you will check if rolls are null
            //if (!Models.UserModel.FindUser(username: username, pass: password))
            //  return ""; // not found
            //var rolesList = Models.UserModel.UserPrivilages(username: username);

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, username));
            
            // This Line part of code is responciple to add roles into the user from the database >> this here only for testing  
            claims.Add(new Claim(ClaimTypes.Role, "test"));
            //foreach (string value in rolesList)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, value));
            //}

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool Validate(string tokenValue, string Roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();
            // TODO: find a way to remove the Try catch ,,
            // basically Identify the error type from Validate token and then add it to the Exception Filter
            try
            {
                SecurityToken validatedToken;
                var principal = tokenHandler.ValidateToken(tokenValue, validationParameters, out validatedToken);

                // This mean the token is valid and no roles needed
                if (string.IsNullOrEmpty(Roles))
                    return true; 

                // token is valid and we need to check roles 
                string[] userRoles = Roles.Split(',');

                foreach (string item in userRoles)
                {
                    // This mean the token is valid and role matched the user in case of true 
                    if (principal.IsInRole(item))
                    return true;
                }
                // this mean the token is valid but no roles matched the user 
                return false;

            }
            catch (Exception e)
            {
                // if token handler could not validate the token an exception
                // will be thrown and result return false
                return false;
            }
        }

        private TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters()
            {
                ValidateLifetime = true, // Because there is no expiration in the generated token
                ValidateAudience = false, // Because there is no audiance in the generated token
                ValidateIssuer = false,   // Because there is no issuer in the generated token
                //ValidIssuer = "Sample",
                //ValidAudience = "Sample",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)), // The same key as the one that generate the token
                RoleClaimType = ClaimTypes.Role
            };
        }


    }
}