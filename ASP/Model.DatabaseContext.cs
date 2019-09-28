using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LearningDbInitialization.Models;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        public DatabaseContext() : base("CountryDb")
        {
            //Database.SetInitializer<DatabaseContext>
            //    (new CreateDatabaseIfNotExists<DatabaseContext>());

            //Database.SetInitializer<DatabaseContext>
            //    (new DropCreateDatabaseIfModelChanges<DatabaseContext>());

            //Database.SetInitializer<DatabaseContext>
            //    (new DropCreateDatabaseAlways<DatabaseContext>());

            Database.SetInitializer<DatabaseContext>(new DatabaseContextInit());
        }
        public System.Data.Entity.DbSet<Country> Countries { get; set; }
        public System.Data.Entity.DbSet<City> Cities { get; set; }

    }
}
