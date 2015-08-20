namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Building_Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Entity_ID = c.Int(),
                        Base_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Buildings", t => t.Entity_ID)
                .ForeignKey("dbo.Bases", t => t.Base_ID)
                .Index(t => t.Entity_ID)
                .Index(t => t.Base_ID);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        BuildTime = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fleets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Location = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Player_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Players", t => t.Player_ID)
                .Index(t => t.Player_ID);
            
            CreateTable(
                "dbo.Ship_Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Entity_ID = c.Int(),
                        Fleet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ships", t => t.Entity_ID)
                .ForeignKey("dbo.Fleets", t => t.Fleet_ID)
                .Index(t => t.Entity_ID)
                .Index(t => t.Fleet_ID);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Attack = c.Int(nullable: false),
                        Defence = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        Speed = c.Double(nullable: false),
                        CargoMax = c.Int(nullable: false),
                        CargoCurr = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        BuildTime = c.Int(nullable: false),
                        ShipType = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Base_ID = c.Int(),
                        Research_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bases", t => t.Base_ID)
                .ForeignKey("dbo.Researches", t => t.Research_ID)
                .Index(t => t.Base_ID)
                .Index(t => t.Research_ID);
            
            CreateTable(
                "dbo.Researches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Research_Data",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Entity_ID = c.Int(),
                        Research_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teches", t => t.Entity_ID)
                .ForeignKey("dbo.Researches", t => t.Research_ID)
                .Index(t => t.Entity_ID)
                .Index(t => t.Research_ID);
            
            CreateTable(
                "dbo.Teches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        price = c.Int(nullable: false),
                        BuildTime = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Player_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Players", t => t.Player_ID)
                .Index(t => t.Player_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Player_ID", "dbo.Players");
            DropForeignKey("dbo.Players", "Research_ID", "dbo.Researches");
            DropForeignKey("dbo.Research_Data", "Research_ID", "dbo.Researches");
            DropForeignKey("dbo.Research_Data", "Entity_ID", "dbo.Teches");
            DropForeignKey("dbo.Fleets", "Player_ID", "dbo.Players");
            DropForeignKey("dbo.Players", "Base_ID", "dbo.Bases");
            DropForeignKey("dbo.Ship_Data", "Fleet_ID", "dbo.Fleets");
            DropForeignKey("dbo.Ship_Data", "Entity_ID", "dbo.Ships");
            DropForeignKey("dbo.Building_Data", "Base_ID", "dbo.Bases");
            DropForeignKey("dbo.Building_Data", "Entity_ID", "dbo.Buildings");
            DropIndex("dbo.Users", new[] { "Player_ID" });
            DropIndex("dbo.Research_Data", new[] { "Research_ID" });
            DropIndex("dbo.Research_Data", new[] { "Entity_ID" });
            DropIndex("dbo.Players", new[] { "Research_ID" });
            DropIndex("dbo.Players", new[] { "Base_ID" });
            DropIndex("dbo.Ship_Data", new[] { "Fleet_ID" });
            DropIndex("dbo.Ship_Data", new[] { "Entity_ID" });
            DropIndex("dbo.Fleets", new[] { "Player_ID" });
            DropIndex("dbo.Building_Data", new[] { "Base_ID" });
            DropIndex("dbo.Building_Data", new[] { "Entity_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Teches");
            DropTable("dbo.Research_Data");
            DropTable("dbo.Researches");
            DropTable("dbo.Players");
            DropTable("dbo.Ships");
            DropTable("dbo.Ship_Data");
            DropTable("dbo.Fleets");
            DropTable("dbo.Buildings");
            DropTable("dbo.Building_Data");
            DropTable("dbo.Bases");
        }
    }
}
