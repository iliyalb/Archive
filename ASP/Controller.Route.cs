using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning_Routing.Controllers
{
    //[Route("person/{action}")]

    //[RoutePrefix("person")]
    //[Route("{action}")]

    //[RoutePrefix("home")]

    //[Route("home/{action}")]

    //[Route("home/{action=TestAction}")]

    //[Route("home/{action=about}/{id?}")]

    [Route("home/{action}-{id}")]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Route("myIndex")]
        public ActionResult Index()
        {
            return View();
        }

        //[Route("about")]
        
        //[Route("home")]
        
        //[Route("home/index")]
        
        //[Route("person/{id}")]
        //public ActionResult About(int id)
        
        //[Route("{year}/{month}/{day}")]
        //public ActionResult About(string year, string month, string day)
        
        //[Route("Home/AboutUs")]
        //[Route("Home/About")]
        
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/About")]
        //public ActionResult About()

        public ActionResult About(int id)
        {
            //return View();
            return Content("id : " + id);
            //return Content(year + " - " + month + " - " + day);
            return View();
        }

        //[Route("person/{name:int}")]
        //[Route("person/{name:minlength(2)}")]
        public ActionResult TestAction(string name)
        {
            ViewBag.Name = name;
            return View();
        }
	}
}