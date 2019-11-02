namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminTableDeletedIsAdminColumnAddedToManager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "IsAdmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Managers", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Managers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Phone", c => c.String(nullable: false));
            DropTable("dbo.Admins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Managers", "Phone", c => c.String());
            DropColumn("dbo.Managers", "Password");
            DropColumn("dbo.Managers", "Username");
            DropColumn("dbo.Managers", "IsAdmin");
        }
    }
}
