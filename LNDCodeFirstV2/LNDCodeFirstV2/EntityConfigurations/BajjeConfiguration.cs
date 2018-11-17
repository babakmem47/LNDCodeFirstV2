using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class BajjeConfiguration : EntityTypeConfiguration<Bajje>
    {
        public BajjeConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Address)
                .HasMaxLength(200);

            /////////// Bajje Relation ///////////////
            // One-To-Many with IpRange:
            HasOptional(bj => bj.IpRange)
                .WithMany(i => i.Bajjes)
                .HasForeignKey(bj => bj.IpRangeId)
                .WillCascadeOnDelete(false);

            // One-to-Many with Branch:
            HasRequired(bj => bj.Branch)
                .WithMany(br => br.Bajjes)
                .HasForeignKey(bj => bj.BranchId)
                .WillCascadeOnDelete(false);

            // One-To-Many with Atm:
            HasMany(bj => bj.Atms)
                .WithOptional(a => a.Bajje)
                .WillCascadeOnDelete(false);

            
            //////////////////////////////////////////

        }
    }
}