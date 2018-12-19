using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class TelNumberConfiguration : EntityTypeConfiguration<TelNumber>
    {
        public TelNumberConfiguration()
        {
            HasKey(tn => tn.Id);   //Primary Key Definition                

            Property(tn => tn.Number)
                .IsRequired()
                .HasMaxLength(14);


        /////////////// TelNumber Relations //////////////

        // Many-To-Many with Person (Config in PersonConfiguration.cs)

        // Many-To-One with TelType
            HasRequired(tn => tn.TelType)
                .WithMany(tt => tt.TelNumbers)
                .HasForeignKey(tn => tn.TelTypeId);
        
        // Many-To-(0..1) with Company
            HasOptional(tn => tn.Company)
                .WithMany(c => c.TelNumbers)
                .HasForeignKey(tn => tn.CompanyId);
         
         // Many-To-(0..1) with Section
            HasOptional(tn => tn.Section)
                .WithMany(sc => sc.TelNumbers)
                .HasForeignKey(tn => tn.SectionId);

         // Many-To-(0..1) with Branch
            HasOptional(tn => tn.Branch)
                .WithMany(br => br.TelNumbers)
                .HasForeignKey(tn => tn.BranchId);

         // Many-To-(0..1) with Bajje
            HasOptional(tn => tn.Bajje)
                .WithMany(bj => bj.TelNumbers)
                .HasForeignKey(tn => tn.BajjeId);

         //////////////////////////////////////////////////


        }
    }
}