namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Avaibility", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "Publisher", c => c.String(nullable: false));
            DropColumn("dbo.Books", "Availbility");
            DropColumn("dbo.Books", "DataAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "DataAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "Availbility", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "Publisher");
            DropColumn("dbo.Books", "DateAdded");
            DropColumn("dbo.Books", "Avaibility");
        }
    }
}
