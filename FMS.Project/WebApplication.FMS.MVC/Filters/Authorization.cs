using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC
{
    public class Authorization : ActionFilterAttribute, IActionFilter
    {
        public IPrincipal principal;
        public string Roles
        {
            get; set;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //string token = context.HttpContext.Session.GetString("TokenNumber");
            string token = context.HttpContext.Request.Cookies["TokenNumber"];
            if (token != null)
            {
                var Role = ValidateToken(token);
                var user = new GenericPrincipal(new ClaimsIdentity(""), Role);
                context.HttpContext.User = user;
                bool result = false;
                if (string.IsNullOrEmpty(Roles) == false)
                {
                    var checkRole = Roles.Split(',');
                    foreach (var role in checkRole)
                    {
                        if (role == null)
                        {
                            result = true;
                        }
                        else if (user.IsInRole(role))
                        {
                            result = true;
                        }
                    }
                    if (result == false)
                    {
                        context.Result = new RedirectToRouteResult
                        (
                        new RouteValueDictionary
                        {
                        {"controller","Home"},
                        {"action","Index"}
                        }
                        );
                    }
                }
                base.OnActionExecuting(context);
            }
            else
            {
                context.Result = new RedirectToRouteResult
                    (
                    new RouteValueDictionary
                    {
                        {"controller","Login"},
                        {"action","Login"}
                    }
                    );
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.

        }

        private string Secret = "ERMN05OPLoDvbTTa/QkqLNMI7cPLguaRyHzyg7n5qNBVjQmtBhz4SzYh4NBVCXi3KJHlSXKP+oi2+bXr6CUYTR==";
        public string[] ValidateToken(string Token)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            TokenValidationParameters parameters = new TokenValidationParameters()
            {
                RequireExpirationTime = false,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(this.Secret)),
                RoleClaimType = ClaimTypes.Role
            };

            SecurityToken validatedToken;
            IPrincipal principal = tokenHandler.ValidateToken(Token, parameters, out validatedToken);
            ClaimsIdentity identity = (ClaimsIdentity)principal.Identity;
            string[] clime = identity.FindAll(ClaimTypes.Role).Select(a => a.Value).ToArray();
            return clime;
        }
    }
}

