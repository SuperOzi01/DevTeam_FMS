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
            var errorType = context.Exception.GetType();
            var ExceptionMessage = context.Exception.Message;
            var InnerMessage = context.Exception.StackTrace;

            var logMessage = string.Format("Web API Exception Logs [ Controller: {0} | Action: {1} | Time: {2} \n Exception Message:{3} \n ---  \n Inner Exception: \n {4}]",
                             context.ActionContext.ControllerContext.ControllerDescriptor.ControllerName,
                             context.ActionContext.ActionDescriptor.ActionName,
                             DateTime.Now.ToShortTimeString(),
                             ExceptionMessage, 
                             InnerMessage
                             );
            logError.Error("--------------------------");
            logError.Error(logMessage);
            context.Response = context.Request.CreateErrorResponse(System.Net.HttpStatusCode.BadRequest, ExceptionMessage);
            
            
        }
    }
}