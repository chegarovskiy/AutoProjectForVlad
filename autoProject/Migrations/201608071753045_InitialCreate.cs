namespace autoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ListOfBrend = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vin = c.Int(nullable: false),
                        IdBrend = c.String(),
                        IdModel = c.String(),
                        IdYearRelis = c.String(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fullName = c.String(),
                        phone = c.Int(nullable: false),
                        address = c.String(),
                        passportData = c.String(),
                        notes = c.String(),
                        orders_money = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelCar = c.String(),
                        Engin = c.String(),
                        Year = c.String(),
                        Bodytype = c.String(),
                        Brend_Id = c.Int(),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brends", t => t.Brend_Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Brend_Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataStart = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DataOut = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Money = c.Single(nullable: false),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.SpeaParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Manufacturer = c.String(),
                        Notes = c.String(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.PriseSpeaParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Prise = c.Single(nullable: false),
                        SpeaPart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpeaParts", t => t.SpeaPart_Id)
                .Index(t => t.SpeaPart_Id);
            
            CreateTable(
                "dbo.DetailToPerforms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emploees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Specialization = c.String(),
                        DetailToPerform_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailToPerforms", t => t.DetailToPerform_Id)
                .Index(t => t.DetailToPerform_Id);
            
            CreateTable(
                "dbo.TypeOfWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfWork = c.String(),
                        ImplementTime = c.Single(nullable: false),
                        Prise = c.Single(nullable: false),
                        DetailToPerform_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailToPerforms", t => t.DetailToPerform_Id)
                .Index(t => t.DetailToPerform_Id);
            
            CreateTable(
                "dbo.SelaryWorkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEmploee = c.Int(nullable: false),
                        DetailToPerform_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailToPerforms", t => t.DetailToPerform_Id)
                .Index(t => t.DetailToPerform_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(maxLength: 4),
                        Position = c.String(),
                        CodeAccsess = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeOfWorkEmploees",
                c => new
                    {
                        TypeOfWork_Id = c.Int(nullable: false),
                        Emploee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TypeOfWork_Id, t.Emploee_Id })
                .ForeignKey("dbo.TypeOfWorks", t => t.TypeOfWork_Id, cascadeDelete: true)
                .ForeignKey("dbo.Emploees", t => t.Emploee_Id, cascadeDelete: true)
                .Index(t => t.TypeOfWork_Id)
                .Index(t => t.Emploee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelaryWorkers", "DetailToPerform_Id", "dbo.DetailToPerforms");
            DropForeignKey("dbo.TypeOfWorkEmploees", "Emploee_Id", "dbo.Emploees");
            DropForeignKey("dbo.TypeOfWorkEmploees", "TypeOfWork_Id", "dbo.TypeOfWorks");
            DropForeignKey("dbo.TypeOfWorks", "DetailToPerform_Id", "dbo.DetailToPerforms");
            DropForeignKey("dbo.Emploees", "DetailToPerform_Id", "dbo.DetailToPerforms");
            DropForeignKey("dbo.PriseSpeaParts", "SpeaPart_Id", "dbo.SpeaParts");
            DropForeignKey("dbo.SpeaParts", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Models", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Models", "Brend_Id", "dbo.Brends");
            DropForeignKey("dbo.Cars", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Brends", "CarId", "dbo.Cars");
            DropIndex("dbo.TypeOfWorkEmploees", new[] { "Emploee_Id" });
            DropIndex("dbo.TypeOfWorkEmploees", new[] { "TypeOfWork_Id" });
            DropIndex("dbo.SelaryWorkers", new[] { "DetailToPerform_Id" });
            DropIndex("dbo.TypeOfWorks", new[] { "DetailToPerform_Id" });
            DropIndex("dbo.Emploees", new[] { "DetailToPerform_Id" });
            DropIndex("dbo.PriseSpeaParts", new[] { "SpeaPart_Id" });
            DropIndex("dbo.SpeaParts", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "Car_Id" });
            DropIndex("dbo.Models", new[] { "Car_Id" });
            DropIndex("dbo.Models", new[] { "Brend_Id" });
            DropIndex("dbo.Cars", new[] { "Client_Id" });
            DropIndex("dbo.Brends", new[] { "CarId" });
            DropTable("dbo.TypeOfWorkEmploees");
            DropTable("dbo.Users");
            DropTable("dbo.SelaryWorkers");
            DropTable("dbo.TypeOfWorks");
            DropTable("dbo.Emploees");
            DropTable("dbo.DetailToPerforms");
            DropTable("dbo.PriseSpeaParts");
            DropTable("dbo.SpeaParts");
            DropTable("dbo.Orders");
            DropTable("dbo.Models");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
            DropTable("dbo.Brends");
        }
    }
}
