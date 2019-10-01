// ~/Infrastructures/BaseController.cs
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
            // Localization to show from ~/App_GlobalResources/ErrorMessages.fa-IR.resx
            CultureInfo oci = new CultureInfo("fa-IR");
            System.Threading.Thread.CurrentThread.CurrentCulture = oci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = oci;
        }
    }
}
