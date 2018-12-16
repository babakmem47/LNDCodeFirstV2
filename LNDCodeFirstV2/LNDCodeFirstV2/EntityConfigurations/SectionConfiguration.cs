using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class SectionConfiguration : EntityTypeConfiguration<Section>
    {
        public SectionConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            /////////// Section Relation ///////////////
            // Many-To-Many with Setad:
            HasMany(sc => sc.Setads)
                .WithMany(st => st.Sections)
                .Map(m =>
                {
                    m.ToTable("SectionSetads");
                    m.MapLeftKey("SectionId");
                    m.MapRightKey("SetadId");
                });

            // (0..1)-To-Many with IpRange:
            HasOptional(sc => sc.IpRange)
                .WithMany(i => i.Sections)
                .HasForeignKey(sc => sc.IpRangeId);


            // Many-To-(0..1) with Person:
            HasMany(sc => sc.Persons)
                .WithOptional(p => p.Section)
                .WillCascadeOnDelete(false);

            ///////////////////////////////////////////


        }
    }
}