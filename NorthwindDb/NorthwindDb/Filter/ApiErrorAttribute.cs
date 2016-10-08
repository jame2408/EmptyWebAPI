using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Filters;

namespace NorthwindDb.Filter
{
    public class ApiErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext != null)
            {
                actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.InternalServerError);
            }            
        }
    }
}