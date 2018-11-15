namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSematsTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Semats (Name) VALUES ('کارشناس')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('کاربر رایانه')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('معاون دایره')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('رئیس دایره')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('متصدی امور بانکی')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('اپراتور')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('پیش خدمت')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('معاون اداره')");
            Sql(@"INSERT INTO Semats (Name) VALUES ('رئیس اداره')");
        }
        
        public override void Down()
        {
        }
    }
}
