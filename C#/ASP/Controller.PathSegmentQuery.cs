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
            return "Home/Profile/ID= \t" + id + " username=<b>" + username.ToString() + "</b>";
            // not safe, HTML can be injected
        }
    }
}