using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
namespace WebApplication
{
    public class Authorization : AuthorizationFilterAttribute
    {
        public string Roles
        {
            get; set;
        }

        private string Secret = "ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            bool auth = ValidateToken(actionContext.Request.Headers.Authorization.Parameter);
            if (auth == true)
            {
                return;
            }
            else
            {
                HttpResponseMessage responseMessage = new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    Content = new StringContent("{ \"Result\":\"false\",\"Message\":\"Unauthorization User\"}")
                };
                responseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                actionContext.Response = responseMessage;
            }

        }
        public bool ValidateToken(string Token)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            TokenValidationParameters parameters = new TokenValidationParameters()
            {
                RequireExpirationTime = false,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(this.Secret)),
                RoleClaimType = ClaimTypes.Role
            };

            try
            {
                SecurityToken validatedToken;
                IPrincipal principal = tokenHandler.ValidateToken(Token, parameters, out validatedToken);
                if (!string.IsNullOrEmpty(Roles))
                {
                    string[] checkRole = Roles.Split(',');
                    foreach (var role in checkRole)
                    {
                        if (role == null)
                        {
                            return true;
                        }
                        else if (principal.IsInRole(role))
                        {
                            return true;
                        }
                    }
                }
                else
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}