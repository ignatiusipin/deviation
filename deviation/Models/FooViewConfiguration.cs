using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace deviation.Models
{
    public class FooViewConfiguration : EntityTypeConfiguration<Deviation_from>
    {
        public FooViewConfiguration()
        {
            this.HasKey(t => t.REQ_ID);
            this.ToTable("deviation_form_v");
        }
    }
    
}