namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSetad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Setads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Shakhes = c.String(maxLength: 4, fixedLength: true),
                        IsModiriatShoab = c.Byte(nullable: false),
                        Address = c.String(maxLength: 200),
                        IpRange = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Setads");
        }
    }
}
