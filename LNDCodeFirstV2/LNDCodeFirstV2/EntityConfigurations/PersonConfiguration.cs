using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirstV2.Models;

namespace LNDCodeFirstV2.EntityConfigurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            //Override the name of the table
            ToTable("Persons");

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.Email)
                .HasMaxLength(30);

            /////////// Person Relation ///////////////
            //(0..1)-To-Many with Semat
            HasOptional(p => p.Semat)
                .WithMany(s => s.Persons)
                .HasForeignKey(p => p.SematId);

            //(0..1)-To-Many with Company
            HasOptional(p => p.Company)
                .WithMany(c => c.Persons)
                .HasForeignKey(p => p.CompanyId);

            //(0..1)-To-Many with Section
            HasOptional(p => p.Section)
                .WithMany(sc => sc.Persons)
                .HasForeignKey(p => p.SectionId);

            //(0..1)-To-Many with Branch
            HasOptional(p => p.Branch)
                .WithMany(br => br.Persons)
                .HasForeignKey(p => p.BranchId);

            //(0..1)-To-Many with Bajje
            HasOptional(p => p.Bajje)
                .WithMany(bj => bj.Persons)
                .HasForeignKey(p => p.BajjeId);

           
            ///////////////////////////////////////////



        }
    }
}