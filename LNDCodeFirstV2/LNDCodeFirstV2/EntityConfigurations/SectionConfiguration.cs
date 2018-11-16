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
            HasMany(sc => sc.Setads)
                .WithMany(st => st.Sections)
                .Map(m =>
                {
                    m.ToTable("SectionSetads");
                    m.MapLeftKey("SectionId");
                    m.MapRightKey("SetadId");
                });

            ///////////////////////////////////////////


        }
    }
}