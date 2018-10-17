namespace PatifoodDataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sss1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Packets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CargoName = c.String(),
                        CargoShippingDate = c.DateTime(),
                        CargoDeliverygDate = c.DateTime(),
                        CargoStatus = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PacketOrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                        OrderProduct_Id = c.Guid(),
                        Packet_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderProducts", t => t.OrderProduct_Id)
                .ForeignKey("dbo.Packets", t => t.Packet_Id)
                .Index(t => t.OrderProduct_Id)
                .Index(t => t.Packet_Id);
            
            CreateTable(
                "dbo.ProductConfigs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OptionCode = c.String(),
                        OptionName = c.String(),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PacketOrderProducts", "Packet_Id", "dbo.Packets");
            DropForeignKey("dbo.PacketOrderProducts", "OrderProduct_Id", "dbo.OrderProducts");
            DropIndex("dbo.PacketOrderProducts", new[] { "Packet_Id" });
            DropIndex("dbo.PacketOrderProducts", new[] { "OrderProduct_Id" });
            DropTable("dbo.ProductConfigs");
            DropTable("dbo.PacketOrderProducts");
            DropTable("dbo.Packets");
        }
    }
}
