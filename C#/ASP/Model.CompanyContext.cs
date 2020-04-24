using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning_EFCF.Models
{
    public class CompanyContext : System.Data.Entity.DbContext
    {
        public CompanyContext()
        {

        }
        public System.Data.Entity.DbSet<Company> Companies { get; set; }
    }
}