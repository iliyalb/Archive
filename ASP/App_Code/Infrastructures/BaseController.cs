using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Infrastructures
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            CultureInfo oci = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = oci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = oci;
        }
    }
}
