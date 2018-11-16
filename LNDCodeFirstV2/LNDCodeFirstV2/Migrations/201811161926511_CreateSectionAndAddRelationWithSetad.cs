namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSectionAndAddRelationWithSetad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SectionSetads",
                c => new
                    {
                        SectionId = c.Int(nullable: false),
                        SetadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SectionId, t.SetadId })
                .ForeignKey("dbo.Sections", t => t.SectionId, cascadeDelete: true)
                .ForeignKey("dbo.Setads", t => t.SetadId, cascadeDelete: true)
                .Index(t => t.SectionId)
                .Index(t => t.SetadId);
            
            DropColumn("dbo.Setads", "IpRange");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Setads", "IpRange", c => c.String(maxLength: 15));
            DropForeignKey("dbo.SectionSetads", "SetadId", "dbo.Setads");
            DropForeignKey("dbo.SectionSetads", "SectionId", "dbo.Sections");
            DropIndex("dbo.SectionSetads", new[] { "SetadId" });
            DropIndex("dbo.SectionSetads", new[] { "SectionId" });
            DropTable("dbo.SectionSetads");
            DropTable("dbo.Sections");
        }
    }
}
