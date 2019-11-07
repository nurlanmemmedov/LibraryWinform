namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttributesCompleted : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Fullname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Managers", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Managers", "Phone", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Fullname", c => c.String(nullable: false));
        }
    }
}
