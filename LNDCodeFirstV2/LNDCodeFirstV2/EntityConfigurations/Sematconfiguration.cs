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

            /////////// Semat Relation ///////////////

            // Many-To-(0..1) with Person
            HasMany(sm => sm.Persons)
                .WithOptional(p => p.Semat)
                .WillCascadeOnDelete(false);
            
            //////////////////////////////////////////

        }
    }
}