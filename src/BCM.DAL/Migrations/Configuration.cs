namespace BCM.DAL.Migrations
{
    using BCM.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public sealed class Configuration : DbMigrationsConfiguration<BCM.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            //string pathRoot =
            //    @"E:\";
                //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //string newPath = Path.Combine(pathRoot, @"Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            //AppDomain.CurrentDomain.SetData(Common.Constants.DataDirectory, newPath);
            
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BCM.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            //RoleActions.createAdmin(context);
            //RoleActions.createUserAndRole(context);

            // GetAuthors().ForEach(a => context.Authors.Add(a));

            // GetCategories().ForEach(c => context.Categories.Add(c));

            // GetBooks().ForEach(b => context.Books.Add(b));

            //IList<Author> authors = GetAuthors();
            //IList<Book> books = GetBooks();
            //IList<Category> categories = GetCategories();

            //Book book = books.First();
            //book.Authors.Add(authors.First());
            //book.Categories.Add(categories.First());

            //context.SaveChanges();
        }

        private List<Author> GetAuthors()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    BirthDate=null, 
                    BirthName="", 
                    BirthPlace="", 
                    DateOfDeath=null, 
                    FirstName="Georges-Louis Leclerc de", 
                    LastName="Buffon",
                    Nationality="", 
                    Notes="", 
                    Photograph=""
                }
            };
            return authors;
        }

        private List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category{ Name="Books",                     Description="", ParentCategoryID=-1 },
                new Category{ Name="Antiques & Collectibles",   Description="", ParentCategoryID=1 },
                new Category{ Name="Architecture",              Description="", ParentCategoryID=1 },
                new Category{ Name="Art",                       Description="", ParentCategoryID=1 },
                new Category{ Name="Biography & Autobiography", Description="", ParentCategoryID=1 },
                new Category{ Name="Computers & Internet",      Description="", ParentCategoryID=1 },
                new Category{ Name="Education",                 Description="", ParentCategoryID=1 },
                new Category{ Name="Fiction",                   Description="", ParentCategoryID=1 },
                new Category{ Name="Children's Fiction",        Description="", ParentCategoryID=1 },
                new Category{ Name="Humor",                     Description="", ParentCategoryID=1 },
                new Category{ Name="History",                   Description="", ParentCategoryID=1 },
                new Category{ Name="Philosophy",                Description="", ParentCategoryID=1 },
                new Category{ Name="Music",                     Description="", ParentCategoryID=1 },
                new Category{ Name="Science",                   Description="", ParentCategoryID=1 },
                new Category{ Name="Travel",                    Description="", ParentCategoryID=1 },
                new Category{ Name="Business & Economics",      Description="", ParentCategoryID=1 },
                new Category{ Name="Reference",                 Description="", ParentCategoryID=1 }, 
                new Category{ Name="Non-Classifiable",          Description="", ParentCategoryID=1 }
            };
            return categories;
        }

        private List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book
                {
                    CopyrightYear=null, 
                    CoverType="", 
                    DatePurchased=null, 
                    EditionNumber=null, 
                    ISBNNumber="", 
                    ListPrice=Decimal.Parse("99.00"), 
                    Location="K5", 
                    Notes="Herrn von Buffons allgemeine Naturgeschichte. Eine freie mit Zusätzen vermehrte neue Übersetzung. Dritter Theil.Mit allergnädigstem Königl. Preuß. Privilegio. Dritter Teil von 1771 und vierter Teil von 1772.", 
                    Pages=null, 
                    PlaceOfPublication="Berlin", 
                    PublisherName="", 
                    PublishingCompany="Bey Joachim Pauli, Buchhändler.", 
                    PublishingYear=1771, 
                    PurchasePrice=null, 
                    Title="Buffons allgemeine Naturgeschichte. III. IV. Theil", 
                    VolumeNumber=null, 
                    ImageUrl="", 
                    ImageUrl2="", 
                    ImageUrl3="", 
                    ImageUrl4=""
                }
            };
            return books;
        }
    }
    
}
