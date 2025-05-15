namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        MailName = c.String(),
                    })
                .PrimaryKey(t => t.MailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mails");
        }
    }
}
