﻿using System.Web.Routing;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string controller = (string)requestContext.RouteData.Values["controller"];
            string action = (string)requestContext.RouteData.Values["action"];

            requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }
}