using ClassLibrary.FMS.DataModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace WebApplication.FMS.WebAPI.App_Start
{
    public class TokenManager
    {
        
        private const string secretKey = "This is the Secrit Key ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";
        public string GenerateToken(LoginModel loginModel)
        {
            // Encrypt the Secret Key 
            var tokenKey = Encoding.ASCII.GetBytes(secretKey);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(tokenKey);

            // Create Token Claims 
            List<Claim> claims = new List<Claim>();
            // Add Username And Role into the Token Claims
            claims.Add(new Claim(ClaimTypes.Name, loginModel.Username));
            claims.Add(new Claim(ClaimTypes.Role, loginModel.Role));
           
            // Create the token Discriptor
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(securityKey,
                SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }

        public bool ValidateToken(string tokenValue)
        {
            SecurityToken validatedToken;
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();
            try
            {
            tokenHandler.ValidateToken(tokenValue, validationParameters, out validatedToken);
            return true;
            }catch(Exception)
            {
                return false;
            }

        }

        public bool AuthorizeToken(string tokenValue , string roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(tokenValue);
            string userRole = GetUserRole(tokenValue);

            string[] controllerRoles = roles.Split(',');

                if (controllerRoles.Contains(userRole))
                    return true;
            
            // this mean the token is valid but no roles matched the user 
            return false;
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
            };
        }

        public string GetUserName(string userToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(userToken);
            var username = token.Claims.FirstOrDefault().Value.ToString();
            return username;
        }

        public string GetUserRole(string userToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(userToken);
            var userRole = token.Claims.ElementAtOrDefault(1).Value.ToString();
            return userRole;
        }

    }
}