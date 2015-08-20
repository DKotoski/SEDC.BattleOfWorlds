namespace SEDC.BattleOfWorlds.Infrastructure.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Building_Data", "Entity_ID", "dbo.Buildings");
            DropForeignKey("dbo.Ship_Data", "Entity_ID", "dbo.Ships");
            DropForeignKey("dbo.Research_Data", "Entity_ID", "dbo.Teches");
            DropIndex("dbo.Building_Data", new[] { "Entity_ID" });
            DropIndex("dbo.Ship_Data", new[] { "Entity_ID" });
            DropIndex("dbo.Research_Data", new[] { "Entity_ID" });
            AddColumn("dbo.Building_Data", "EntityID", c => c.Int(nullable: false));
            AddColumn("dbo.Ship_Data", "EntityID", c => c.Int(nullable: false));
            AddColumn("dbo.Research_Data", "EntityID", c => c.Int(nullable: false));
            DropColumn("dbo.Building_Data", "Entity_ID");
            DropColumn("dbo.Ship_Data", "Entity_ID");
            DropColumn("dbo.Research_Data", "Entity_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Research_Data", "Entity_ID", c => c.Int());
            AddColumn("dbo.Ship_Data", "Entity_ID", c => c.Int());
            AddColumn("dbo.Building_Data", "Entity_ID", c => c.Int());
            DropColumn("dbo.Research_Data", "EntityID");
            DropColumn("dbo.Ship_Data", "EntityID");
            DropColumn("dbo.Building_Data", "EntityID");
            CreateIndex("dbo.Research_Data", "Entity_ID");
            CreateIndex("dbo.Ship_Data", "Entity_ID");
            CreateIndex("dbo.Building_Data", "Entity_ID");
            AddForeignKey("dbo.Research_Data", "Entity_ID", "dbo.Teches", "ID");
            AddForeignKey("dbo.Ship_Data", "Entity_ID", "dbo.Ships", "ID");
            AddForeignKey("dbo.Building_Data", "Entity_ID", "dbo.Buildings", "ID");
        }
    }
}
