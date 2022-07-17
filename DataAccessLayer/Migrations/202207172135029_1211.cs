namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1211 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Presentation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsPresentation = c.Boolean(nullable: false),
                        MovieID = c.Int(nullable: false),
                        SaloonID = c.Byte(nullable: false),
                        SessionID = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Saloons", t => t.SaloonID, cascadeDelete: true)
                .ForeignKey("dbo.Sessions", t => t.SessionID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.SaloonID)
                .Index(t => t.SessionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Presentation", "SessionID", "dbo.Sessions");
            DropForeignKey("dbo.Presentation", "SaloonID", "dbo.Saloons");
            DropForeignKey("dbo.Presentation", "MovieID", "dbo.Movies");
            DropIndex("dbo.Presentation", new[] { "SessionID" });
            DropIndex("dbo.Presentation", new[] { "SaloonID" });
            DropIndex("dbo.Presentation", new[] { "MovieID" });
            DropTable("dbo.Presentation");
        }
    }
}
