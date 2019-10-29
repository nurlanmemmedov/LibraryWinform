namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneColumnAddedToManager : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Phone");
        }
    }
}
