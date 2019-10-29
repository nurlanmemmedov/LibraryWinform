namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorColumnAddedToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Books", "Author");
        }
    }
}
