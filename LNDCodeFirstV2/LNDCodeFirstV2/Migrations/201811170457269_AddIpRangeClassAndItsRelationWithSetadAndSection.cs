namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIpRangeClassAndItsRelationWithSetadAndSection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IpRanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Range = c.String(nullable: false, maxLength: 15),
                        Mask = c.String(nullable: false, maxLength: 2, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sections", "IpRangeId", c => c.Int());
            AddColumn("dbo.Setads", "IpRangeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Sections", "IpRangeId");
            CreateIndex("dbo.Setads", "IpRangeId");
            AddForeignKey("dbo.Sections", "IpRangeId", "dbo.IpRanges", "Id");
            AddForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges");
            DropForeignKey("dbo.Sections", "IpRangeId", "dbo.IpRanges");
            DropIndex("dbo.Setads", new[] { "IpRangeId" });
            DropIndex("dbo.Sections", new[] { "IpRangeId" });
            DropColumn("dbo.Setads", "IpRangeId");
            DropColumn("dbo.Sections", "IpRangeId");
            DropTable("dbo.IpRanges");
        }
    }
}
