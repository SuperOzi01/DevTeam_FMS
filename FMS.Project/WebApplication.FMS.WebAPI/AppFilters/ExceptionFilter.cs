using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication.FMS.WebAPI.AppFilters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var msg = "ExceptionFilter { Action: " + context.ActionContext.ActionDescriptor.ActionName + " | Time: " + DateTime.Now.ToShortTimeString() + " }";
            string exception = context.Exception.InnerException.Message;
            Console.WriteLine(exception);
            switch(exception)
            {
                case "System.DivideByZeroException":
                    Console.WriteLine("Divide By Zero Exception");
                    break;
            }

        }
    }
}