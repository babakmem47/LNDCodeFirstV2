namespace LNDCodeFirstV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSematsTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('کارشناس')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('کاربر رایانه')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('معاون دایره')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('رئیس دایره')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('متصدی امور بانکی')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('اپراتور')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('پیش خدمت')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('معاون اداره')");
            Sql(@"INSERT INTO TABLE Semats (Name) VALUES ('رئیس اداره')");
        }
        
        public override void Down()
        {
        }
    }
}
