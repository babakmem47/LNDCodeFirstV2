using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class IpRangeConfiguration : EntityTypeConfiguration<IpRange>
    {
        public IpRangeConfiguration()
        {
            Property(i => i.Range)
                .IsRequired()
                .HasMaxLength(15);

            Property(i => i.Mask)
                .IsRequired()
                .HasMaxLength(2).IsFixedLength();


            /////////// IpRange Relation ///////////////
            // One-To-Many with Setad:
            HasMany(i => i.Setads)
                .WithRequired(st => st.IpRange);

            // (0..1)-To-Many with Section:
            HasMany(i => i.Sections)
                .WithOptional(sc => sc.IpRange);

            ////////////////////////////////////////////

        }
    }
}