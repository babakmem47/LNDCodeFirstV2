namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePersonClass : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Persons");
            AlterColumn("dbo.Persons", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Persons", "Email", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "Email", c => c.String());
            AlterColumn("dbo.Persons", "Name", c => c.String());
            RenameTable(name: "dbo.Persons", newName: "People");
        }
    }
}
