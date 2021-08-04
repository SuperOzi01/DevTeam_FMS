using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApplication.FMS.WebAPI.AppFilters
{
    public class LogsFilterWebAPI : Attribute, IActionFilter
    {
        public bool AllowMultiple => true;
        log4net.ILog log = log4net.LogManager.GetLogger("InfoLog");

        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            // Request Time
            var logMessage = string.Format("Web API Request Logs [ Controller: {0} | Action: {1} | Time: {2} ]",
                actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                actionContext.ActionDescriptor.ActionName,
                DateTime.Now.ToShortTimeString());
            var result = continuation();

            // Here you should write to the logs file For Request
            log.Info("--------------------------");
            log.Info(logMessage);

            // Responce Message
            logMessage = string.Format("Web API Responce Logs => Controller: {0} | Action: {1} | Time: {2} ",
                actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                actionContext.ActionDescriptor.ActionName,
                DateTime.Now.ToShortTimeString());
            // Here you should write to the logs file For Responce 
            log.Info(logMessage);
            return result;
        }
    }
}