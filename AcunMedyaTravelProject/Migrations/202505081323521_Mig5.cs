namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "ImageUrl", c => c.String());
            AddColumn("dbo.Booking2", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Booking2", "ImageUrl");
            DropColumn("dbo.Bookings", "ImageUrl");
        }
    }
}
