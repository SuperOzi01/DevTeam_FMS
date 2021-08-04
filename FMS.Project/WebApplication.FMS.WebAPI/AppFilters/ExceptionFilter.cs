using ClassLibrary.FMS.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication.FMS.WebAPI.AppFilters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            log4net.ILog logError = log4net.LogManager.GetLogger("ErrorLog");
            var logMessage = string.Format("Web API Exception Logs [ Controller: {0} | Action: {1} | Time: {2} ]",
                             context.ActionContext.ControllerContext.ControllerDescriptor.ControllerName,
                             context.ActionContext.ActionDescriptor.ActionName,
                             DateTime.Now.ToShortTimeString());
            var errorType = context.Exception.GetType();
            ResponseAPI responce = new ResponseAPI();

            //Respone to Error Type 
            switch (errorType.FullName)
            {
                case "System.DivideByZeroException":
                    //Identify Error Based On The Exception;
                    break;
                case "System.UnauthorizedAccessException":
                    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "You Are Not Authorized Based On The Roles");
                    break;
                case "Microsoft.IdentityModel.Tokens.SecurityTokenSignatureKeyNotFoundException":
                    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized,"Invalid Token");
                    break;
                case "Microsoft.IdentityModel.Tokens.SecurityTokenExpiredException":
                    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "Token Time Expired");
                    break;
                default:
                    context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "404 UnKnown Issue, Try Later :)");
                    break;
            }
            logError.Error("--------------------------");
            logError.Error(logMessage);
        }
    }
}