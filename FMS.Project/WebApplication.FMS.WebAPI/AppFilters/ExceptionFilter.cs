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
            var logMessage = "ExceptionFilter { Action: " + context.ActionContext.ActionDescriptor.ActionName
                                            + " | Time: " + DateTime.Now.ToShortTimeString() 
                                            + " }";
            var errorType = context.Exception.GetType();

            //Respone to Error Type 
            switch (errorType.FullName)
            {
                case "System.DivideByZeroException":
                    //Identify Error Based On The Exception;
                    break;
            }

        }
    }
}