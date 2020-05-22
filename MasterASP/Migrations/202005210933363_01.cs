namespace MasterASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cart",
                c => new
                    {
                        cart_id = c.Int(nullable: false, identity: true),
                        product_id = c.Int(),
                        product_name = c.String(nullable: false, maxLength: 65),
                        unit_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        discontinued = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cart_id)
                .ForeignKey("dbo.products", t => t.product_id)
                .Index(t => t.product_id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        product_id = c.Int(nullable: false, identity: true),
                        category_id = c.Int(),
                        product_name = c.String(nullable: false, maxLength: 65),
                        image_product = c.String(nullable: false),
                        unit_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        units_in_stock = c.Int(nullable: false),
                        units_on_order = c.Int(nullable: false),
                        discontinued = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.product_id)
                .ForeignKey("dbo.categories", t => t.category_id)
                .Index(t => t.category_id);
            
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        category_id = c.Int(nullable: false, identity: true),
                        category_name = c.String(nullable: false, maxLength: 20),
                        description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.category_id);
            
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        customer_id = c.String(nullable: false, maxLength: 128),
                        first_name = c.String(maxLength: 20),
                        last_name = c.String(maxLength: 20),
                        address = c.String(nullable: false, maxLength: 60),
                        city = c.String(maxLength: 20),
                        region = c.String(maxLength: 15),
                        postal_code = c.String(maxLength: 5),
                        country = c.String(maxLength: 20),
                        phon = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.customer_id);
            
            CreateTable(
                "dbo.orders",
                c => new
                    {
                        order_id = c.Int(nullable: false, identity: true),
                        product_id = c.String(),
                        product_ProductId = c.Int(),
                        Customer_CustomerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.order_id)
                .ForeignKey("dbo.products", t => t.product_ProductId)
                .ForeignKey("dbo.customers", t => t.Customer_CustomerId)
                .Index(t => t.product_ProductId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.order_details",
                c => new
                    {
                        order_id = c.Int(nullable: false),
                        product_id = c.Int(nullable: false),
                        unit_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Int(nullable: false),
                        discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.order_id, t.product_id })
                .ForeignKey("dbo.orders", t => t.order_id, cascadeDelete: true)
                .ForeignKey("dbo.products", t => t.product_id, cascadeDelete: true)
                .Index(t => t.order_id)
                .Index(t => t.product_id);
            
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        employee_id = c.Int(nullable: false, identity: true),
                        first_name = c.String(maxLength: 15),
                        last_name = c.String(maxLength: 15),
                        title = c.String(maxLength: 15),
                        title_of_courtesy = c.String(maxLength: 20),
                        birth_date = c.DateTime(nullable: false),
                        hire_date = c.DateTime(nullable: false),
                        address = c.String(maxLength: 60),
                        city = c.String(maxLength: 20),
                        region = c.String(maxLength: 15),
                        postal_code = c.Int(nullable: false),
                        country = c.String(maxLength: 20),
                        extension = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.employee_id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.shippers",
                c => new
                    {
                        shipper_id = c.Int(nullable: false, identity: true),
                        company_name = c.String(nullable: false, maxLength: 25),
                        phon = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.shipper_id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.orders", "Customer_CustomerId", "dbo.customers");
            DropForeignKey("dbo.orders", "product_ProductId", "dbo.products");
            DropForeignKey("dbo.order_details", "product_id", "dbo.products");
            DropForeignKey("dbo.order_details", "order_id", "dbo.orders");
            DropForeignKey("dbo.cart", "product_id", "dbo.products");
            DropForeignKey("dbo.products", "category_id", "dbo.categories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.order_details", new[] { "product_id" });
            DropIndex("dbo.order_details", new[] { "order_id" });
            DropIndex("dbo.orders", new[] { "Customer_CustomerId" });
            DropIndex("dbo.orders", new[] { "product_ProductId" });
            DropIndex("dbo.products", new[] { "category_id" });
            DropIndex("dbo.cart", new[] { "product_id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.shippers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.employees");
            DropTable("dbo.order_details");
            DropTable("dbo.orders");
            DropTable("dbo.customers");
            DropTable("dbo.categories");
            DropTable("dbo.products");
            DropTable("dbo.cart");
        }
    }
}
