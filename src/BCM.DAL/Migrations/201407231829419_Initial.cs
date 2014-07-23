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
                        Birthplace = c.String(),
                        Nationality = c.String(),
                        DateofDeath = c.DateTime(),
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
            DropForeignKey("dbo.BcmUserRoles", "RoleId", "dbo.BcmRoles");
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
            DropIndex("dbo.BcmUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.BcmUserRoles", new[] { "RoleId" });
            DropIndex("dbo.BcmRoles", "RoleNameIndex");
            DropTable("dbo.BcmBookCategory");
            DropTable("dbo.BcmBookAuthor");
            DropTable("dbo.BcmUserLogins");
            DropTable("dbo.BcmUserClaims");
            DropTable("dbo.BcmUsers");
            DropTable("dbo.BcmUserRoles");
            DropTable("dbo.BcmRoles");
            DropTable("dbo.BcmCategory");
            DropTable("dbo.BcmBook");
            DropTable("dbo.BcmAuthor");
        }
    }
}
