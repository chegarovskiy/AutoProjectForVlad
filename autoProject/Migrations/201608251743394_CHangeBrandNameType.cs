namespace autoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CHangeBrandNameType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Brends", "CarId", "dbo.Cars");
            DropIndex("dbo.Brends", new[] { "CarId" });
            RenameColumn(table: "dbo.Brends", name: "CarId", newName: "Car_Id");
            AddColumn("dbo.Brends", "BrandName", c => c.String());
            AddColumn("dbo.Models", "ModelName", c => c.String());
            AlterColumn("dbo.Brends", "Car_Id", c => c.Int());
            CreateIndex("dbo.Brends", "Car_Id");
            AddForeignKey("dbo.Brends", "Car_Id", "dbo.Cars", "Id");
            DropColumn("dbo.Brends", "ListOfBrend");
            DropColumn("dbo.Models", "ModelCar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "ModelCar", c => c.String());
            AddColumn("dbo.Brends", "ListOfBrend", c => c.Int(nullable: false));
            DropForeignKey("dbo.Brends", "Car_Id", "dbo.Cars");
            DropIndex("dbo.Brends", new[] { "Car_Id" });
            AlterColumn("dbo.Brends", "Car_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Models", "ModelName");
            DropColumn("dbo.Brends", "BrandName");
            RenameColumn(table: "dbo.Brends", name: "Car_Id", newName: "CarId");
            CreateIndex("dbo.Brends", "CarId");
            AddForeignKey("dbo.Brends", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
        }
    }
}
