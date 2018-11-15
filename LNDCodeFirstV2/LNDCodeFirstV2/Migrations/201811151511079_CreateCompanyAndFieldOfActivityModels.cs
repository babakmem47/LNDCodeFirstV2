namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCompanyAndFieldOfActivityModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 200),
                        Email = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FieldOfActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyFieldOfActivities",
                c => new
                    {
                        CompanyId = c.Int(nullable: false),
                        FieldOfActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CompanyId, t.FieldOfActivityId })
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.FieldOfActivities", t => t.FieldOfActivityId, cascadeDelete: true)
                .Index(t => t.CompanyId)
                .Index(t => t.FieldOfActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyFieldOfActivities", "FieldOfActivityId", "dbo.FieldOfActivities");
            DropForeignKey("dbo.CompanyFieldOfActivities", "CompanyId", "dbo.Companies");
            DropIndex("dbo.CompanyFieldOfActivities", new[] { "FieldOfActivityId" });
            DropIndex("dbo.CompanyFieldOfActivities", new[] { "CompanyId" });
            DropTable("dbo.CompanyFieldOfActivities");
            DropTable("dbo.FieldOfActivities");
            DropTable("dbo.Companies");
        }
    }
}
