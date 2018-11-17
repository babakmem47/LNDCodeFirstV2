using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Shakhes)
                .IsRequired()
                .HasMaxLength(4).IsFixedLength();

            Property(p => p.IsMomtaz)
                .IsRequired();

            Property(p => p.Address)
                .HasMaxLength(200);

            /////////// Branch Relation ///////////////
            // One-To-Many with IpRange:
            HasRequired(br => br.IpRange)
                .WithMany(i => i.Branches)
                .HasForeignKey(br => br.IpRangeId)
                .WillCascadeOnDelete(false);

            // (0..1)-To-Many with Bajje:
            HasMany(br => br.Bajjes)
                .WithRequired(bj => bj.Branch)
                .WillCascadeOnDelete(false);

            // (0..1)-To-Many with Atm:
            HasMany(br => br.Atms)
                .WithRequired(a => a.Branch)
                .WillCascadeOnDelete(false);


            ///////////////////////////////////////////

        }
    }
}