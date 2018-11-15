namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiForSemat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Semats", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Semats", "Name", c => c.String());
        }
    }
}
