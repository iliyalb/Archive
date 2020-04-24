using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ~/App_Start/FilterConfig.cs

namespace SOLUTION_NAME
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection filters)
        {
            // Default error handler
            //filters.Add(new System.Web.Mvc.HandleErrorAttribute());
            
            // Custom error handler (higher priority)
            filters.Add(new Infrastructures.CustomHandleErrorAttribute());
        }
    }
}