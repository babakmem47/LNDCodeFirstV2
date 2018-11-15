using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class SematConfiguration : EntityTypeConfiguration<Semat>
    {
        public SematConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}