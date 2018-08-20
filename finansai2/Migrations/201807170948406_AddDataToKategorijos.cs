namespace finansai2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToKategorijos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Kategorijas (Name) VALUES ('Maistas')");
            Sql("INSERT INTO Kategorijas (Name) VALUES ('Transportas')");
            Sql("INSERT INTO Kategorijas (Name) VALUES ('Komunalines')");
            Sql("INSERT INTO Kategorijas (Name) VALUES ('Kitos')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Kategorijas WHERE Id In (1,2,3,4)");
        }
    }
}
