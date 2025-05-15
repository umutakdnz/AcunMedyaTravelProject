namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationsID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.DestinationsID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServicesID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ImageUrl = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
            DropTable("dbo.Categories");
        }
    }
}
