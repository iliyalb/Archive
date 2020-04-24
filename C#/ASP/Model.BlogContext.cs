using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class BlogContext : System.Data.Entity.DbContext
    {
        public BlogContext()
        {

        }
        public System.Data.Entity.DbSet<Blog> Blogs { get; set; }
    }
}