using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

// ~/App_Code/Infrastructures/CustomHandleErrorAttribute.cs

// Define filters.Add(new Infrastructures.CustomHandleErrorAttribute()); in ~/App_Start/FilterConfig.cs

// Usage in controllers: [Infrastructures.CustomHandleError]
namespace Infrastructures
{
    class CustomHandleErrorAttribute : System.Web.Mvc.HandleErrorAttribute
    {
        public CustomHandleErrorAttribute()
        {
            // ctor
        }

        public override void OnException(System.Web.Mvc.ExceptionContext filterContext)
        {
            base.OnException(filterContext);

            System.IO.StreamWriter writer = new System.IO.StreamWriter(HttpContext.Current.Server.MapPath("~/App_Data/Log.txt"), true);

            writer.WriteLine("Time: " + System.DateTime.Now + " IP Address: " + HttpContext.Current.Request.UserHostAddress + " Message: " +
                filterContext.Exception.Message +  " Path: " + HttpContext.Current.Request.PhysicalPath);                
            
            writer.Dispose();
        }
    }
}