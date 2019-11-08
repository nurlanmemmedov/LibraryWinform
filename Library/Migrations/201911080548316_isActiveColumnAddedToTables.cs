namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isActiveColumnAddedToTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "isActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Books", "isActive", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.Managers", "isActive", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "isActive");
            DropColumn("dbo.Managers", "isActive");
            DropColumn("dbo.Books", "isActive");
        }
    }
}
