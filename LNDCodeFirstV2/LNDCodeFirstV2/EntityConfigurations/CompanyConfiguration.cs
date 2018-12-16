using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Address)
                .HasMaxLength(200);

            Property(p => p.Email)
                .HasMaxLength(30);

            /////////////// Company Relations //////////////

            //Many-To-Many with FieldOfActivity
            HasMany(c => c.FieldOfActivities)
                .WithMany(f => f.Companies)
                .Map(m =>
                {
                    m.ToTable("CompanyFieldOfActivities");
                    m.MapLeftKey("CompanyId");
                    m.MapRightKey("FieldOfActivityId");
                });

            // Many-To-(0..1) with Person
            HasMany(c => c.Persons)
                .WithOptional(p => p.Company)
                .WillCascadeOnDelete(false);

            /////////////////////////////////////////////////
            

        }
    }
}