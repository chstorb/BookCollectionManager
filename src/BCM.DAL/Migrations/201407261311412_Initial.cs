namespace BCM.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BcmAuthor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false),
                        BirthName = c.String(),
                        FirstName = c.String(),
                        BirthDate = c.DateTime(),
                        BirthPlace = c.String(),
                        Nationality = c.String(),
                        DateOfDeath = c.DateTime(),
                        Photograph = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BcmBook",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        CopyrightYear = c.Int(),
                        ISBNNumber = c.String(),
                        PublishingCompany = c.String(),
                        PublisherName = c.String(),
                        PublishingYear = c.Int(),
                        PlaceOfPublication = c.String(),
                        VolumeNumber = c.Int(),
                        EditionNumber = c.Int(),
                        CoverType = c.String(),
                        Pages = c.Int(),
                        Location = c.String(),
                        Notes = c.String(),
                        PurchasePrice = c.Decimal(precision: 18, scale: 2),
                        DatePurchased = c.DateTime(),
                        ListPrice = c.Decimal(precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        ImageUrl2 = c.String(),
                        ImageUrl3 = c.String(),
                        ImageUrl4 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BcmCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ParentCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BcmOrderDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        UserName = c.String(),
                        BookId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ListPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BcmOrder", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.BcmOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 160),
                        LastName = c.String(nullable: false, maxLength: 160),
                        Address = c.String(nullable: false, maxLength: 70),
                        City = c.String(nullable: false, maxLength: 40),
                        State = c.String(nullable: false, maxLength: 40),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                        Country = c.String(nullable: false, maxLength: 40),
                        Phone = c.String(maxLength: 24),
                        Email = c.String(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTransactionId = c.String(),
                        HasBeenShipped = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BcmRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.BcmUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.BcmRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.BcmUsers", t => t.IdentityUser_Id)
                .Index(t => t.RoleId)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.BcmCartItem",
                c => new
                    {
                        ItemId = c.String(nullable: false, maxLength: 128),
                        CartId = c.String(),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.BcmBook", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.BcmUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BcmUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BcmUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.BcmUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.BcmUsers", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.BcmBookAuthor",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookId, t.AuthorId })
                .ForeignKey("dbo.BcmBook", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.BcmAuthor", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.BcmBookCategory",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookId, t.CategoryId })
                .ForeignKey("dbo.BcmBook", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.BcmCategory", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BcmUserRoles", "IdentityUser_Id", "dbo.BcmUsers");
            DropForeignKey("dbo.BcmUserLogins", "IdentityUser_Id", "dbo.BcmUsers");
            DropForeignKey("dbo.BcmUserClaims", "IdentityUser_Id", "dbo.BcmUsers");
            DropForeignKey("dbo.BcmCartItem", "BookId", "dbo.BcmBook");
            DropForeignKey("dbo.BcmUserRoles", "RoleId", "dbo.BcmRoles");
            DropForeignKey("dbo.BcmOrderDetail", "OrderId", "dbo.BcmOrder");
            DropForeignKey("dbo.BcmBookCategory", "CategoryId", "dbo.BcmCategory");
            DropForeignKey("dbo.BcmBookCategory", "BookId", "dbo.BcmBook");
            DropForeignKey("dbo.BcmBookAuthor", "AuthorId", "dbo.BcmAuthor");
            DropForeignKey("dbo.BcmBookAuthor", "BookId", "dbo.BcmBook");
            DropIndex("dbo.BcmBookCategory", new[] { "CategoryId" });
            DropIndex("dbo.BcmBookCategory", new[] { "BookId" });
            DropIndex("dbo.BcmBookAuthor", new[] { "AuthorId" });
            DropIndex("dbo.BcmBookAuthor", new[] { "BookId" });
            DropIndex("dbo.BcmUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.BcmUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.BcmCartItem", new[] { "BookId" });
            DropIndex("dbo.BcmUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.BcmUserRoles", new[] { "RoleId" });
            DropIndex("dbo.BcmRoles", "RoleNameIndex");
            DropIndex("dbo.BcmOrderDetail", new[] { "OrderId" });
            DropTable("dbo.BcmBookCategory");
            DropTable("dbo.BcmBookAuthor");
            DropTable("dbo.BcmUserLogins");
            DropTable("dbo.BcmUserClaims");
            DropTable("dbo.BcmUsers");
            DropTable("dbo.BcmCartItem");
            DropTable("dbo.BcmUserRoles");
            DropTable("dbo.BcmRoles");
            DropTable("dbo.BcmOrder");
            DropTable("dbo.BcmOrderDetail");
            DropTable("dbo.BcmCategory");
            DropTable("dbo.BcmBook");
            DropTable("dbo.BcmAuthor");
        }
    }
}
