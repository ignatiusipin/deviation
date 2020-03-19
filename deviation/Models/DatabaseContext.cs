using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace deviation.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DB_DO")
        {
        }

        public DbSet<Deviation> Deviations { get; set; }
    }
}