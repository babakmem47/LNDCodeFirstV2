namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSematsTable1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Semats (Name) VALUES ('آبدارچی')");
        }
        
        public override void Down()
        {
        }
    }
}
