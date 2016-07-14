using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BaseApi.Filters
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class NullCheckModelAttribute : ActionFilterAttribute
    {
        private readonly Func<Dictionary<string, object>, bool> _validate;

        public NullCheckModelAttribute() : this(arguments => arguments.ContainsValue(null))
        { }

        public NullCheckModelAttribute(Func<Dictionary<string, object>, bool> checkCondition)
        {
            _validate = checkCondition;
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (_validate(actionContext.ActionArguments))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(
                HttpStatusCode.BadRequest, "The argument cannot be null");
            }
        }
    }
}