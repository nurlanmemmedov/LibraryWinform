namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTablesNameChanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Clients");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Clients", newName: "Users");
        }
    }
}
