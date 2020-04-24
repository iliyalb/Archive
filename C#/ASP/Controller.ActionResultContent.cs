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

        // Changes method name in URL page segments
        [ActionName("SumAction")]
        public ActionResult ShowResult()
        {
            string message = Sum(10, 20).ToString();

            return Content(message); //will generate error without Content
        }

        // Hides this method from URL page segments
        [NonAction]
        public int Sum(int i, int j)
        {
            return i + j;
        }
    }
}