using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Post
    {
        public int Id { get; set; }
        public DatTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

// App.config:
/* <connectionStrings>
    <add name="BlogDbContext" connectionString="data source=.\SQLEXPRESS; initial catalog=CodeFirst; integrated security=SSPI" providerName="System.Data.SqlClient"/>
</connectionStrings> */

// PM> enable-migrations

// PM> add-migration CreatePost

// PM> Update-Database