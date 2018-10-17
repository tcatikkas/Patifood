namespace PatifoodDataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        category_id = c.String(),
                        image = c.String(),
                        icon = c.String(),
                        parent_id = c.Int(nullable: false),
                        top = c.Byte(nullable: false),
                        bottom = c.Byte(nullable: false),
                        column = c.Byte(nullable: false),
                        left = c.Byte(nullable: false),
                        sort_order = c.Byte(nullable: false),
                        status = c.Byte(nullable: false),
                        date_close = c.String(),
                        date_added = c.String(),
                        date_modified = c.String(),
                        entegrasyon_code = c.String(),
                        taksit_ayarlari = c.String(),
                        language_id = c.Byte(nullable: false),
                        name = c.String(),
                        title = c.String(),
                        description = c.String(),
                        footer_description = c.String(),
                        meta_description = c.String(),
                        meta_keyword = c.String(),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        order_product_id = c.Int(nullable: false),
                        BirimName = c.String(),
                        Birim = c.Int(),
                        customer_id = c.String(),
                        name = c.String(),
                        model = c.String(),
                        quantity = c.Byte(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price_code = c.String(),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        reward = c.Byte(nullable: false),
                        receiving_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        option_name = c.String(),
                        option_code = c.String(),
                        tax_class_description = c.String(),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                        order_Id = c.Guid(),
                        product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.order_Id)
                .ForeignKey("dbo.Products", t => t.product_Id)
                .Index(t => t.order_Id)
                .Index(t => t.product_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        order_id = c.Int(nullable: false),
                        customer_id = c.Short(nullable: false),
                        customer_group_id = c.Byte(nullable: false),
                        firstname = c.String(),
                        lastname = c.String(),
                        email = c.String(),
                        telephone = c.String(),
                        gsm = c.String(),
                        fax = c.String(),
                        payment_firstname = c.String(),
                        payment_lastname = c.String(),
                        payment_company = c.String(),
                        payment_company_id = c.String(),
                        payment_tax_id = c.String(),
                        payment_address_1 = c.String(),
                        payment_address_2 = c.String(),
                        payment_city = c.String(),
                        payment_gsm = c.String(),
                        payment_postcode = c.String(),
                        payment_country = c.String(),
                        payment_country_id = c.Byte(nullable: false),
                        payment_zone = c.String(),
                        payment_zone_id = c.Short(nullable: false),
                        payment_address_format = c.String(),
                        payment_method = c.String(),
                        payment_bank = c.String(),
                        payment_installment = c.Byte(nullable: false),
                        payment_code = c.String(),
                        bank_transfer_discount = c.Byte(nullable: false),
                        shipping_firstname = c.String(),
                        shipping_lastname = c.String(),
                        shipping_company = c.String(),
                        shipping_address_1 = c.String(),
                        shipping_address_2 = c.String(),
                        shipping_city = c.String(),
                        shipping_gsm = c.String(),
                        shipping_postcode = c.String(),
                        shipping_country = c.String(),
                        shipping_country_id = c.Byte(nullable: false),
                        shipping_zone = c.String(),
                        shipping_zone_id = c.Short(nullable: false),
                        shipping_address_format = c.String(),
                        shipping_method = c.String(),
                        comment = c.String(),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        order_status_id = c.Byte(nullable: false),
                        currency_id = c.Byte(nullable: false),
                        currency_code = c.String(),
                        currency_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        forwarded_ip = c.String(),
                        date_added = c.String(),
                        date_modified = c.String(),
                        is_viewed = c.Byte(nullable: false),
                        customer = c.String(),
                        shipping_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        payment_fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        genel_toplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        product_id = c.Int(nullable: false),
                        model = c.String(),
                        location = c.String(),
                        quantity = c.Long(nullable: false),
                        stock_status_id = c.Byte(nullable: false),
                        video = c.String(),
                        image = c.String(),
                        manufacturer_id = c.Int(nullable: false),
                        yazar_id = c.String(),
                        yayinevi_id = c.String(),
                        cevirmen_id = c.String(),
                        tur_id = c.String(),
                        shipping_free = c.Byte(nullable: false),
                        shipping_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        shipping_day = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price_code = c.String(),
                        receiving_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tax_class_id = c.Byte(nullable: false),
                        date_available = c.String(),
                        weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        minimum = c.Byte(nullable: false),
                        maximum = c.Byte(nullable: false),
                        sort_order = c.Byte(nullable: false),
                        show_mainpage = c.Byte(nullable: false),
                        show_badges = c.String(),
                        status = c.Byte(nullable: false),
                        index_status = c.Byte(nullable: false),
                        date_in_stock = c.String(),
                        date_added = c.String(),
                        date_modified = c.String(),
                        entegrasyon_code = c.String(),
                        show_export = c.Byte(nullable: false),
                        customer_id = c.Byte(nullable: false),
                        language_id = c.Byte(nullable: false),
                        name = c.String(),
                        title = c.String(),
                        small_description = c.String(),
                        description = c.String(),
                        delivery_info = c.String(),
                        meta_description = c.String(),
                        meta_keyword = c.String(),
                        tag = c.String(),
                        category_names = c.String(),
                        special_customer_group_id = c.String(),
                        special_price = c.String(),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                        category_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateCreated = c.DateTime(),
                        LastUpdated = c.DateTime(),
                        Category_Id = c.Guid(),
                        Product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", "product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductCategories", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Products", "category_Id", "dbo.Categories");
            DropForeignKey("dbo.OrderProducts", "order_Id", "dbo.Orders");
            DropIndex("dbo.ProductCategories", new[] { "Product_Id" });
            DropIndex("dbo.ProductCategories", new[] { "Category_Id" });
            DropIndex("dbo.Products", new[] { "category_Id" });
            DropIndex("dbo.OrderProducts", new[] { "product_Id" });
            DropIndex("dbo.OrderProducts", new[] { "order_Id" });
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Categories");
        }
    }
}
