namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuideProfiles",
                c => new
                    {
                        ProfileID = c.Int(nullable: false, identity: true),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileID)
                .ForeignKey("dbo.TourGuides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.TourGuides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Uname = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.TourAssignments",
                c => new
                    {
                        AssignmentID = c.Int(nullable: false, identity: true),
                        GuideID = c.Int(nullable: false),
                        TourID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssignmentID)
                .ForeignKey("dbo.Tours", t => t.TourID, cascadeDelete: true)
                .ForeignKey("dbo.TourGuides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID)
                .Index(t => t.TourID);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourID = c.Int(nullable: false, identity: true),
                        TourLocation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TourID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(nullable: false),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.TourGuides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.TravelerProfiles",
                c => new
                    {
                        TravelerID = c.Int(nullable: false, identity: true),
                        TravelerName = c.String(nullable: false),
                        TravelerPhone = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.TravelerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "GuideID", "dbo.TourGuides");
            DropForeignKey("dbo.GuideProfiles", "GuideID", "dbo.TourGuides");
            DropForeignKey("dbo.TourAssignments", "GuideID", "dbo.TourGuides");
            DropForeignKey("dbo.TourAssignments", "TourID", "dbo.Tours");
            DropIndex("dbo.Locations", new[] { "GuideID" });
            DropIndex("dbo.TourAssignments", new[] { "TourID" });
            DropIndex("dbo.TourAssignments", new[] { "GuideID" });
            DropIndex("dbo.GuideProfiles", new[] { "GuideID" });
            DropTable("dbo.TravelerProfiles");
            DropTable("dbo.Locations");
            DropTable("dbo.Tours");
            DropTable("dbo.TourAssignments");
            DropTable("dbo.TourGuides");
            DropTable("dbo.GuideProfiles");
        }
    }
}
