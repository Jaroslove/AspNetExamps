using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetExamps.Controllers
{
    public class UserController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string controller = requestContext.RouteData.Values["controller"].ToString();

            string action = requestContext.RouteData.Values["action"].ToString();

            requestContext.HttpContext.Response.Write($"Controller is {controller} and action is {action}");
        }
    }
}