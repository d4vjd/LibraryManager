namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Stores", newName: "Libraries");
            DropPrimaryKey("dbo.Libraries");
            AlterColumn("dbo.Libraries", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Libraries", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Libraries");
            AlterColumn("dbo.Libraries", "Id", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Libraries", "Id");
            RenameTable(name: "dbo.Libraries", newName: "Stores");
        }
    }
}
