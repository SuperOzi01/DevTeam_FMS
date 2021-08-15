using ClassLibrary.FMS.DataModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApplication.FMS.WebAPI.App_Start;

namespace WebApplication.FMS.WebAPI.AppFilters
{
    public class AuthinticationManager : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.GetValues("Authorization").FirstOrDefault();
            if(token == null)
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Token Was Not Provided");

            bool result = new TokenManager().ValidateToken(token);
            if(result)
            {
                return;
            }
            actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Unable to validate the token");
           
        }

    }
}