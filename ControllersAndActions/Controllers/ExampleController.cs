using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            // URL не может быть обслужен
            return new HttpStatusCodeResult(404, "URL cannot be serviced");
        }
    }
}