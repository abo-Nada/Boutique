namespace Boutique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.billDetails",
                c => new
                    {
                        billDetailsId = c.Int(nullable: false, identity: true),
                        billId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                        count = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        size = c.String(),
                    })
                .PrimaryKey(t => t.billDetailsId)
                .ForeignKey("dbo.Bills", t => t.billId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.billId)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        billId = c.Int(nullable: false, identity: true),
                        billDate = c.DateTime(nullable: false),
                        totalPrice = c.Double(nullable: false),
                        userId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.billId)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.userId);
            
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
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        code = c.String(),
                        productName = c.String(nullable: false),
                        description = c.String(),
                        price = c.Double(nullable: false),
                        availableCount = c.Int(nullable: false),
                        color = c.String(),
                        categoryId = c.Int(nullable: false),
                        typeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.typeId, cascadeDelete: true)
                .Index(t => t.categoryId)
                .Index(t => t.typeId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.productImgs",
                c => new
                    {
                        productImgId = c.Int(nullable: false, identity: true),
                        imgName = c.String(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productImgId)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.productSizes",
                c => new
                    {
                        productSizeId = c.Int(nullable: false, identity: true),
                        size = c.String(nullable: false),
                        availableSizeCount = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productSizeId)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        typeId = c.Int(nullable: false, identity: true),
                        typeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.typeId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.billDetails", "productId", "dbo.Products");
            DropForeignKey("dbo.Products", "typeId", "dbo.Types");
            DropForeignKey("dbo.productSizes", "productId", "dbo.Products");
            DropForeignKey("dbo.productImgs", "productId", "dbo.Products");
            DropForeignKey("dbo.Products", "categoryId", "dbo.Categories");
            DropForeignKey("dbo.billDetails", "billId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "userId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.productSizes", new[] { "productId" });
            DropIndex("dbo.productImgs", new[] { "productId" });
            DropIndex("dbo.Products", new[] { "typeId" });
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Bills", new[] { "userId" });
            DropIndex("dbo.billDetails", new[] { "productId" });
            DropIndex("dbo.billDetails", new[] { "billId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Types");
            DropTable("dbo.productSizes");
            DropTable("dbo.productImgs");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Bills");
            DropTable("dbo.billDetails");
        }
    }
}
