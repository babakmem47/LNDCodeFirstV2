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
            // Many-To-One with Setad:
            HasMany(i => i.Setads)
                .WithRequired(st => st.IpRange)
                .WillCascadeOnDelete(false);

            // Many-To-(0..1) with Section:
            HasMany(i => i.Sections)
                .WithOptional(sc => sc.IpRange)
                .WillCascadeOnDelete(false);

            // Many-To-One with Branch
            HasMany(i => i.Branches)
                .WithRequired(b => b.IpRange)
                .WillCascadeOnDelete(false);

            // Many-To-(0..1) with Bajje
            HasMany(i => i.Bajjes)
                .WithOptional(b => b.IpRange)
                .WillCascadeOnDelete(false);

            // Many-To-One with Atm
            HasMany(i => i.Atms)
                .WithRequired(b => b.IpRange)
                .WillCascadeOnDelete(false);

            ////////////////////////////////////////////

        }
    }
}