namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTelNumberRelationsFluentApis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TelNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 14),
                        TelTypeId = c.Int(nullable: false),
                        CompanyId = c.Int(),
                        SectionId = c.Int(),
                        BranchId = c.Int(),
                        BajjeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bajjes", t => t.BajjeId)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .ForeignKey("dbo.TelTypes", t => t.TelTypeId)
                .Index(t => t.TelTypeId)
                .Index(t => t.CompanyId)
                .Index(t => t.SectionId)
                .Index(t => t.BranchId)
                .Index(t => t.BajjeId);
            
            CreateTable(
                "dbo.PersonTelNumbers",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        TelNumberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonId, t.TelNumberId })
                .ForeignKey("dbo.Persons", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.TelNumbers", t => t.TelNumberId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.TelNumberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonTelNumbers", "TelNumberId", "dbo.TelNumbers");
            DropForeignKey("dbo.PersonTelNumbers", "PersonId", "dbo.Persons");
            DropForeignKey("dbo.TelNumbers", "TelTypeId", "dbo.TelTypes");
            DropForeignKey("dbo.TelNumbers", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.TelNumbers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.TelNumbers", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.TelNumbers", "BajjeId", "dbo.Bajjes");
            DropIndex("dbo.PersonTelNumbers", new[] { "TelNumberId" });
            DropIndex("dbo.PersonTelNumbers", new[] { "PersonId" });
            DropIndex("dbo.TelNumbers", new[] { "BajjeId" });
            DropIndex("dbo.TelNumbers", new[] { "BranchId" });
            DropIndex("dbo.TelNumbers", new[] { "SectionId" });
            DropIndex("dbo.TelNumbers", new[] { "CompanyId" });
            DropIndex("dbo.TelNumbers", new[] { "TelTypeId" });
            DropTable("dbo.PersonTelNumbers");
            DropTable("dbo.TelNumbers");
        }
    }
}
