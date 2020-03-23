using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace deviation.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DB_DO")
        {
        }

        public DbSet<Deviation> Deviations { get; set; }
        public DbSet<Deviation_from> DeviationForm { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FooViewConfiguration());
        }
    }
}