using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestView.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        // Shows a string in Home/Index
        public string Index()
        {
            return "Hello Havij!";
        }

        // Returns a ViewResult in Home/Index2
        public ActionResult Index2()
        {
            return View(); // ~/Views/Home/Index2.cshtml
        }

        // Redirects to Home/NotIndex while still showing Home/Index3 URL
        public ActionResult Index3()
        {
            return View("NotIndex"); // ~/Views/Home/NotIndex.cshtml
        }

        // Relative redirection to a view
        public ActionResult Index4()
        {
            return View("~/Views/Example/SomeIndex.cshtml");
        }
	}
}