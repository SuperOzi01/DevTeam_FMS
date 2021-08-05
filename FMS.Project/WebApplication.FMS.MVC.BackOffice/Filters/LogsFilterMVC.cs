using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication.FMS.MVC.Filters
{
    public class LogsFilterMVC : Attribute, IActionFilter
    {
        log4net.ILog log = log4net.LogManager.GetLogger("InfoLog");
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Request Time
            var logMessage = string.Format("MVC Controller Request Logs [ Controller: {0} | Action: {1} | Time: {2} ]",
                context.Controller.ToString(),
                context.ActionDescriptor.DisplayName,
                DateTime.Now.ToShortTimeString());

            // Here you should write to the logs file For Request
            log.Info("--------------------------");
            log.Info(logMessage);
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
