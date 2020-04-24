using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

// ~/Utilities/Extension.cs

namespace Utilities
{
    public static class Extension
    {
        public static string MyControl
            (this System.Web.Mvc.HtmlHelper helper,
            string target, string name)
        {
            return string.Format("<label for='{0}'>{1}<label><input type='text' name='{0}' />",
                                    target, name);
        }

        public static IHtmlString YourControl
            (this System.Web.Mvc.HtmlHelper helper,
            string target, string name)
        {
             string strControl = string.Format("<label for='{0}'>{1}<label><input type='text' name='{0}' />",
                                    target, name);
             return helper.Raw(strControl);
        }
    }
}
