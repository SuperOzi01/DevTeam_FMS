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
            bool result = new TokenManager().ValidateToken(actionContext.Request.Headers.GetValues("Authorization").FirstOrDefault());
            if(result)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, "Welcome");
                return;
            }
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Unable to validate the token");
           
        }

    }
}