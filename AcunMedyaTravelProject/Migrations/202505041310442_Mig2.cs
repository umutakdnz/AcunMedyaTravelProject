namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Booking2",
                c => new
                    {
                        Booking2ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Booking2ID);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
            DropTable("dbo.Booking2");
            DropTable("dbo.Bookings");
        }
    }
}
