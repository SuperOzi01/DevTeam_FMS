using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.Filters
{
    public class ExceptionFilterMVC : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            log4net.ILog logError = log4net.LogManager.GetLogger("ErrorLog");
            var errorType = context.Exception.GetType();
            var ExceptionMessage = context.Exception.Message;
            var InnerMessage = context.Exception.InnerException.StackTrace;

            var logMessage = string.Format("Web API Exception Logs [ HTTP Path: {0} | Action: {1} | Time: {2} \n Exception Message:{3} \n ---  \n Inner Exception: \n {4}]",
                             context.RouteData.Values["controller"].ToString(),
                             context.RouteData.Values["action"].ToString(),
                             DateTime.Now.ToShortTimeString(),
                             ExceptionMessage,
                             InnerMessage
                             );
            logError.Error("--------------------------");
            logError.Error(logMessage);

            context.ExceptionHandled = true;
            context.Result = new ViewResult()
            {
                ViewName = "ErrorView" // here add the name of the view
            };
        }
    }
}
