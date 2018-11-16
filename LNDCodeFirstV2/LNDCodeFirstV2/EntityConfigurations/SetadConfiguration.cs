using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class SetadConfiguration : EntityTypeConfiguration<Setad>
    {
        public SetadConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Shakhes)
                .HasMaxLength(4).IsFixedLength();

            Property(p => p.IsModiriatShoab)
                .IsRequired();


            Property(p => p.Address)
                .HasMaxLength(200);


            /////////// Setad Relation ///////////////

            // Many-To-Many relationship with Section(in SectionConfiguration)

            //////////////////////////////////////////

        }
    }
}