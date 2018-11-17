namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBranchBajjeAtmAndRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges");
            CreateTable(
                "dbo.Atms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Shakhes = c.String(nullable: false, maxLength: 4, fixedLength: true),
                        IsInsideBranch = c.Boolean(nullable: false),
                        Address = c.String(maxLength: 200),
                        BajjeId = c.Int(),
                        BranchId = c.Int(nullable: false),
                        IpRangeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bajjes", t => t.BajjeId)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.IpRanges", t => t.IpRangeId)
                .Index(t => t.BajjeId)
                .Index(t => t.BranchId)
                .Index(t => t.IpRangeId);
            
            CreateTable(
                "dbo.Bajjes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 200),
                        BranchId = c.Int(nullable: false),
                        IpRangeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.IpRanges", t => t.IpRangeId)
                .Index(t => t.BranchId)
                .Index(t => t.IpRangeId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Shakhes = c.String(nullable: false, maxLength: 4, fixedLength: true),
                        IsMomtaz = c.Boolean(nullable: false),
                        Address = c.String(maxLength: 200),
                        SetadId = c.Int(),
                        IpRangeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Setads", t => t.SetadId)
                .ForeignKey("dbo.IpRanges", t => t.IpRangeId)
                .Index(t => t.SetadId)
                .Index(t => t.IpRangeId);
            
            AddForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges");
            DropForeignKey("dbo.Atms", "IpRangeId", "dbo.IpRanges");
            DropForeignKey("dbo.Atms", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Atms", "BajjeId", "dbo.Bajjes");
            DropForeignKey("dbo.Bajjes", "IpRangeId", "dbo.IpRanges");
            DropForeignKey("dbo.Bajjes", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Branches", "IpRangeId", "dbo.IpRanges");
            DropForeignKey("dbo.Branches", "SetadId", "dbo.Setads");
            DropIndex("dbo.Branches", new[] { "IpRangeId" });
            DropIndex("dbo.Branches", new[] { "SetadId" });
            DropIndex("dbo.Bajjes", new[] { "IpRangeId" });
            DropIndex("dbo.Bajjes", new[] { "BranchId" });
            DropIndex("dbo.Atms", new[] { "IpRangeId" });
            DropIndex("dbo.Atms", new[] { "BranchId" });
            DropIndex("dbo.Atms", new[] { "BajjeId" });
            DropTable("dbo.Branches");
            DropTable("dbo.Bajjes");
            DropTable("dbo.Atms");
            AddForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges", "Id", cascadeDelete: true);
        }
    }
}
