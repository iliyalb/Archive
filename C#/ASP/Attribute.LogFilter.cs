// Attributes go to the same folder as Controllers but require Attribute postfix
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Learning_ActionFilterAttribute.Controllers
{
    // [LogFilter(mandatory: true)] attribute can be written on top of class or actions
    public class LogFilterAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public LogFilterAttribute(bool mandatory)
        {
            Mandatory = mandatory;
        }

        public bool Mandatory { get; set; }

        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (Mandatory)
            {
                string path = HttpContext.Current.Server.MapPath("~/App_Data/ActionLog.txt");
                StreamWriter oStreamWriter = new StreamWriter(path, true);
                string controller = filterContext.RouteData.Values["controller"].ToString();
                string action = filterContext.RouteData.Values["action"].ToString();
                string time = System.DateTime.Now.ToString();
                oStreamWriter.Write(controller + "/" + action + "/" + time + "/");
                oStreamWriter.Close();
                oStreamWriter.Dispose();
            }
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext)
        {
            if (Mandatory)
            {
                string path = HttpContext.Current.Server.MapPath("~/App_Data/ActionLog.txt");
                StreamWriter oStreamWriter = new StreamWriter(path, true);
                string time = System.DateTime.Now.ToString();
                oStreamWriter.WriteLine(time);
                oStreamWriter.Close();
                oStreamWriter.Dispose();
            }
            base.OnResultExecuted(filterContext);
        }
    }
}