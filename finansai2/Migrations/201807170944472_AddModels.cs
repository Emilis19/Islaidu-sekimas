namespace finansai2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Islaidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsleidejasId = c.String(nullable: false, maxLength: 128),
                        DateTime = c.DateTime(nullable: false),
                        Suma = c.Double(nullable: false),
                        KategorijaId = c.Byte(nullable: false),
                        Kategorija_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.IsleidejasId, cascadeDelete: true)
                .ForeignKey("dbo.Kategorijas", t => t.Kategorija_Id)
                .Index(t => t.IsleidejasId)
                .Index(t => t.Kategorija_Id);
            
            CreateTable(
                "dbo.Kategorijas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Islaidas", "Kategorija_Id", "dbo.Kategorijas");
            DropForeignKey("dbo.Islaidas", "IsleidejasId", "dbo.AspNetUsers");
            DropIndex("dbo.Islaidas", new[] { "Kategorija_Id" });
            DropIndex("dbo.Islaidas", new[] { "IsleidejasId" });
            DropTable("dbo.Kategorijas");
            DropTable("dbo.Islaidas");
        }
    }
}
