namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ISBN = c.String(nullable: false, maxLength: 50),
                        Title = c.String(nullable: false, maxLength: 50),
                        Author = c.String(nullable: false, maxLength: 50),
                        PublicationDate = c.DateTime(nullable: false),
                        Publisher = c.String(nullable: false, maxLength: 50),
                        Genre = c.String(nullable: false, maxLength: 50),
                        Summary = c.String(nullable: false, maxLength: 500),
                        CoverImage = c.String(maxLength: 200),
                        Rating = c.Double(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ISBN)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Books", new[] { "Client_Id" });
            DropTable("dbo.Libraries");
            DropTable("dbo.Clients");
            DropTable("dbo.Books");
        }
    }
}
