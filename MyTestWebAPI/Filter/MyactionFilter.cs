using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MyTestWebAPI.Filter
{
    public class MyactionFilterAttribute :Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Filter之前");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Filter之后");
        }
    }
}
