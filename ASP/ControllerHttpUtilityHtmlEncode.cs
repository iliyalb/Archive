using System.Web;
using System.Web.Mvc;

namespace ControllerTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // localhost:44313/Home/Profile
        // localhost:44313/Home/Profile?id=15&username=sag
        // localhost:44313/Home/Profile/15?username=sag
        public new string Profile(int? id, string username = "Test")
        {
            return HttpUtility.HtmlEncode("Home/Profile/ID= \t" + id + " username=" + username);
        }
    }
}