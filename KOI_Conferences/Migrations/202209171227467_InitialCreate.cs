namespace KOI_Conferences.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationId = c.Int(nullable: false, identity: true),
                        RegistrationFee = c.Single(nullable: false),
                        SeminarType = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Seminar_Id = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.RegistrationId)
                .ForeignKey("dbo.Seminars", t => t.Seminar_Id)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.Seminar_Id)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Seminars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SeminarType = c.String(nullable: false),
                        RegistrationFee = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FullName = c.String(),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Registrations", "Seminar_Id", "dbo.Seminars");
            DropIndex("dbo.Registrations", new[] { "User_UserId" });
            DropIndex("dbo.Registrations", new[] { "Seminar_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Seminars");
            DropTable("dbo.Registrations");
        }
    }
}
