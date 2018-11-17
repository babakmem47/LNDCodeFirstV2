using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class AtmConfiguration : EntityTypeConfiguration<Atm>
    {
        public AtmConfiguration()
        {
            Property(p => p.Shakhes)
                .IsRequired()
                .HasMaxLength(4).IsFixedLength();

            Property(p => p.IsInsideBranch)
                .IsRequired();

            Property(p => p.Address)
                .HasMaxLength(200);


            /////////// Atm Relation ///////////////
            // One-To-Many with IpRange:
            HasRequired(a => a.IpRange)
                .WithMany(i => i.Atms)
                .HasForeignKey(a => a.IpRangeId);

            // One-To-Many with Branch:
            HasRequired(a => a.Branch)
                .WithMany(br => br.Atms)
                .HasForeignKey(a => a.BranchId);

            // (0..1)-To-Many with Bajje:
            HasOptional(a => a.Bajje)
                .WithMany(bj => bj.Atms)
                .HasForeignKey(a => a.BajjeId);

            
            ////////////////////////////////////////

        }
    }
}