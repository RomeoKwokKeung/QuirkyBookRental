namespace QuirkyBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRegsiter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RentalCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RentalCount");
        }
    }
}
