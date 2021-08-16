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
using WebApplication.FMS.WebAPI.App_Start;
using WebApplication.FMS.WebAPI.AppFilters;

namespace WebApplication
{
    public class AuthorizationManager : AuthorizationFilterAttribute
    {
        public string Roles { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.GetValues("Authorization").FirstOrDefault();
            if (token == null)
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Token Was Not Provided");

            bool result = new TokenManager().AuthorizeToken(token, Roles);
            if (result == false)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized , "You Are Not Authorized To Proced"); 
            }
            else
                return;
        }
    }
}