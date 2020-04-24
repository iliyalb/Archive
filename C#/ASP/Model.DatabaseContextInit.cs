using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class DatabaseContextInit: System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>
    {
        public DatabaseContextInit()
        {

        }

        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
