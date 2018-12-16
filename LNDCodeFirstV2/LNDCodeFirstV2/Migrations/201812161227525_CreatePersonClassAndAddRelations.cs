namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonClassAndAddRelations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        SematId = c.Int(),
                        CompanyId = c.Int(),
                        SectionId = c.Int(),
                        BranchId = c.Int(),
                        BajjeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Semats", t => t.SematId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.Bajjes", t => t.BajjeId)
                .Index(t => t.SematId)
                .Index(t => t.CompanyId)
                .Index(t => t.SectionId)
                .Index(t => t.BranchId)
                .Index(t => t.BajjeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "BajjeId", "dbo.Bajjes");
            DropForeignKey("dbo.People", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.People", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.People", "SematId", "dbo.Semats");
            DropForeignKey("dbo.People", "CompanyId", "dbo.Companies");
            DropIndex("dbo.People", new[] { "BajjeId" });
            DropIndex("dbo.People", new[] { "BranchId" });
            DropIndex("dbo.People", new[] { "SectionId" });
            DropIndex("dbo.People", new[] { "CompanyId" });
            DropIndex("dbo.People", new[] { "SematId" });
            DropTable("dbo.People");
        }
    }
}
