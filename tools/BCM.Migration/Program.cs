using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Migration
{
    using BCM.Common;
    using BCM.DAL;
    using BCM.Model;
    using System.Data.OleDb;

    using System.Linq;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Reflection;
    using System.IO;
    using System.Data;

    class Program
    {
        static void Main(string[] args)
        {
            string dataDirectory = @"Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data";
            string fullPath = @"E:\STC\Office365\Access\2010\Books\Books_be.mdb";

            try
            {
                Migration migration = new Migration(dataDirectory);
                migration.Execute(fullPath);

                //string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Documents\Books.xml");            
                //migration.BuildDataSet(filePath);
                //migration.ReadXml(filePath);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(String.Format("{0}\n", ex.Message));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(String.Format("{0}\n\n\t{1}\n", ex.Message, ex.FileName));
            }

#if DEBUG
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey(true);
#endif
        }
    }

    /// <summary>
    /// Migration class
    /// The Migration class is used to migrate data from a Microsoft Access database to SQL Server LocalDB.
    /// </summary>
    internal sealed class Migration
    {
        #region Constructor

        public Migration(string dataDirectory)
        {
            string pathRoot = Path.GetPathRoot(Assembly.GetExecutingAssembly().Location);
            string newPath = Path.Combine(pathRoot, dataDirectory);

            if (!Directory.Exists(newPath))
            {
                throw new ArgumentException("Invalid path!", "dataDirectory");
            }

            AppDomain.CurrentDomain.SetData(Common.Constants.DataDirectory, newPath);
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Execute method
        /// </summary>
        /// <param name="connectionString">Microsoft Access connection string</param>
        public void Execute(string fullPath)
        {
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("File not found!", fullPath);
            }
                        
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", fullPath);

            try
            {
                con.Open();

                OleDbCommand cmdCategories = new OleDbCommand();

                OleDbCommand cmdBooks = new OleDbCommand();
                cmdBooks.CommandText = "SELECT * FROM Book";
                cmdBooks.Connection = con;

                Dictionary<int, Book> books = new Dictionary<int, Book>();

                OleDbDataReader readerBooks = cmdBooks.ExecuteReader();
                while (readerBooks.Read())
                {
                    Book book = new Book();
                    
                    int id = readerBooks.GetInt32(0);
                    books.Add(id, book);

                    if (!String.IsNullOrEmpty(readerBooks["CopyrightYear"].ToString()))
                    {
                        book.CopyrightYear = int.Parse(readerBooks["CopyrightYear"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["CoverType"].ToString()))
                    {
                        book.CoverType = readerBooks["CoverType"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["DatePurchased"].ToString()))
                    {
                        book.DatePurchased = DateTime.Parse(readerBooks["DatePurchased"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["EditionNumber"].ToString()))
                    {
                        book.EditionNumber = int.Parse(readerBooks["EditionNumber"].ToString());
                    }                                       

                    if (!String.IsNullOrEmpty(readerBooks["ISBNNumber"].ToString()))
                    {
                        book.ISBNNumber = readerBooks["ISBNNumber"].ToString();
                    }
                    if (!String.IsNullOrEmpty(readerBooks["ListPrice"].ToString()))
                    {
                        book.ListPrice = decimal.Parse(readerBooks["ListPrice"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["ShelfNumber"].ToString()))
                    {
                        book.Location = readerBooks["ShelfNumber"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["Notes"].ToString()))
                    {
                        book.Notes = readerBooks["Notes"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["Pages"].ToString()))
                    {
                        book.Pages = int.Parse(readerBooks["Pages"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["PlaceOfPublication"].ToString()))
                    {
                        book.PlaceOfPublication = readerBooks["PlaceOfPublication"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["PublisherName"].ToString()))
                    {
                        book.PublisherName = readerBooks["PublisherName"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["PublishingCompany"].ToString()))
                    {
                        book.PublishingCompany = readerBooks["PublishingCompany"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["PublishingYear"].ToString()))
                    {
                        book.PublishingYear = int.Parse(readerBooks["PublishingYear"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["PurchasePrice"].ToString()))
                    {
                        book.PurchasePrice = decimal.Parse(readerBooks["PurchasePrice"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["Title"].ToString()))
                    {
                        book.Title = readerBooks["Title"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["VolumeNumber"].ToString()))
                    {
                        book.VolumeNumber = int.Parse(readerBooks["VolumeNumber"].ToString());
                    }

                    if (!String.IsNullOrEmpty(readerBooks["ImageUrl"].ToString()))
                    {
                        book.ImageUrl = readerBooks["ImageUrl"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["ImageUrl2"].ToString()))
                    {
                        book.ImageUrl2 = readerBooks["ImageUrl2"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["ImageUrl3"].ToString()))
                    {
                        book.ImageUrl3 = readerBooks["ImageUrl3"].ToString();
                    }

                    if (!String.IsNullOrEmpty(readerBooks["ImageUrl4"].ToString()))
                    {
                        book.ImageUrl4 = readerBooks["ImageUrl4"].ToString();
                    }
                }
                readerBooks.Close();

                OleDbCommand cmdBookAuthor = new OleDbCommand();

                cmdBookAuthor.CommandText = "SELECT Author.*"
                    + " FROM Author INNER JOIN BookAuthor ON Author.AuthorID = BookAuthor.AuthorID"
                    + " WHERE (((BookAuthor.BookID)=@p1));";
                cmdBookAuthor.Parameters.Add("@p1", OleDbType.Integer);
                cmdBookAuthor.Connection = con;

                foreach (KeyValuePair<int, Book> kvp in books)
                {
                    Book book = (kvp.Value) as Book;

                    cmdBookAuthor.Parameters["@p1"].Value = kvp.Key.ToString();

                    OleDbDataReader readerBookAuthor = cmdBookAuthor.ExecuteReader();

                    if (readerBookAuthor.HasRows)
                    {
                        while (readerBookAuthor.Read())
                        {
                            Author author = new Author();

                            if (!String.IsNullOrEmpty(readerBookAuthor["BirthDate"].ToString()))
                            {
                                author.BirthDate = DateTime.Parse(readerBookAuthor["BirthDate"].ToString());
                            }
                            author.BirthName = String.Empty;
                            if (!String.IsNullOrEmpty(readerBookAuthor["BirthPlace"].ToString()))
                            {
                                author.BirthPlace = readerBookAuthor["BirthPlace"].ToString();
                            }
                            if (!String.IsNullOrEmpty(readerBookAuthor["DateOfDeath"].ToString()))
                            {
                                author.DateOfDeath = DateTime.Parse(readerBookAuthor["DateOfDeath"].ToString());
                            }
                            if (!String.IsNullOrEmpty(readerBookAuthor["FirstName"].ToString()))
                            {
                                author.FirstName = readerBookAuthor["FirstName"].ToString();
                            }
                            if (!String.IsNullOrEmpty(readerBookAuthor["LastName"].ToString()))
                            {
                                author.LastName = readerBookAuthor["LastName"].ToString();
                            }
                            if (!String.IsNullOrEmpty(readerBookAuthor["Nationality"].ToString()))
                            {
                                author.Nationality = readerBookAuthor["Nationality"].ToString();
                            }
                            if (!String.IsNullOrEmpty(readerBookAuthor["Notes"].ToString()))
                            {
                                author.Notes = readerBookAuthor["Notes"].ToString();
                            }
                            author.Photograph = String.Empty;

                            book.Authors.Add(author);
                        }
                    }
                    readerBookAuthor.Close();
                }


                BCM.DAL.ApplicationDbContext context = new BCM.DAL.ApplicationDbContext();

                List<Category> categories = new List<Category>
                {
                    new Category{ Name="Books",                     Description=String.Empty, ParentCategoryID=-1 },
                    new Category{ Name="Antiques & Collectibles",   Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Architecture",              Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Art",                       Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Biography & Autobiography", Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Computers & Internet",      Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Education",                 Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Fiction",                   Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Children's Fiction",        Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Humor",                     Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="History",                   Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Philosophy",                Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Music",                     Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Science",                   Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Travel",                    Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Business & Economics",      Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Reference",                 Description=String.Empty, ParentCategoryID=1 },
                    new Category{ Name="Non-Classifiable",          Description=String.Empty, ParentCategoryID=1 }
                };
                categories.ForEach(c => context.Categories.Add(c));
                context.SaveChanges();

                Category parentCategory = categories.Find(c => c.Name.Equals("Antiques & Collectibles"));
                Category catMilitary = new Category { Name="Military", Description=String.Empty, ParentCategoryID=parentCategory.ID };
                context.Categories.Add(catMilitary);
                context.SaveChanges();
                
                Category category = categories.Find(c => c.Name.Equals("Non-Classifiable"));

                foreach (KeyValuePair<int, Book> kvp in books)
                {
                    Book book = ((Book)kvp.Value);

                    if ((book.Title.StartsWith("Biennial report of THE CHIEF OF STAFF"))
                        || (book.Title.StartsWith("Die Kämpfe der deutschen Truppen")))
                    {
                        book.Categories.Add(catMilitary);
                    }
                    else
                    {
                        book.Categories.Add(category);
                    }

                    context.Books.Add(book);

                    Console.WriteLine("{0}\t{1}", kvp.Key, book.Title);
                    foreach (Author author in book.Authors)
                    {
                        Console.WriteLine("\t\t{0}\t{1}", author.LastName, author.FirstName);
                    }
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed!\n{0}\n", e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion Methods

        #region Dataset

        public void ReadXml(string filePath)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);

            Console.WriteLine("\n=======================================================\n");

            foreach (DataTable dataTable in dataSet.Tables)
            {
                Console.WriteLine("Table: {0}", dataTable.TableName);
            }

            var books = dataSet.Tables["Book"].AsEnumerable();

            var query = from b in books
                        select b;

            foreach (var book in books)
            {
                Console.WriteLine(book.Field<string>("Title"));
            }
        }

        public void WriteXml(DataSet dataSet, string filePath)
        {
            string xmlData = dataSet.GetXml();

            dataSet.WriteXml(filePath, XmlWriteMode.WriteSchema);
        }

        public void BuildDataSet(string filePath)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\STC\Office365\Access\2010\Books\Books_be.mdb";

            try
            {
                con.Open();

                DataSet dataSet = new DataSet("BCM");


                DataTable dataTableCategory = new DataTable("Category");

                DataColumn dataColumnCategoryCategoryId = new DataColumn { ColumnName = "ID", DataType = Type.GetType("System.Int32") };
                dataTableCategory.Columns.Add(dataColumnCategoryCategoryId);
                dataTableCategory.Columns.Add(new DataColumn { ColumnName = "Name", DataType = Type.GetType("System.String") });
                dataTableCategory.Columns.Add(new DataColumn { ColumnName = "Description", DataType = Type.GetType("System.String") });
                dataTableCategory.Columns.Add(new DataColumn { ColumnName = "ParentCategoryID", DataType = Type.GetType("System.Int32") });

                dataTableCategory.Rows.Add(1, "Books", String.Empty, -1);
                dataTableCategory.Rows.Add(2, "Antiques & Collectibles", String.Empty, 1);
                dataTableCategory.Rows.Add(3, "Architecture", String.Empty, 1);
                dataTableCategory.Rows.Add(4, "Art", String.Empty, 1);
                dataTableCategory.Rows.Add(5, "Biography & Autobiography", String.Empty, 1);
                dataTableCategory.Rows.Add(6, "Computers & Internet", String.Empty, 1);
                dataTableCategory.Rows.Add(7, "Education", String.Empty, 1);
                dataTableCategory.Rows.Add(8, "Fiction", String.Empty, 1);
                dataTableCategory.Rows.Add(9, "Children's Fiction", String.Empty, 1);
                dataTableCategory.Rows.Add(10, "Humor", String.Empty, 1);
                dataTableCategory.Rows.Add(11, "History", String.Empty, 1);
                dataTableCategory.Rows.Add(12, "Philosophy", String.Empty, 1);
                dataTableCategory.Rows.Add(13, "Music", String.Empty, 1);
                dataTableCategory.Rows.Add(14, "Science", String.Empty, 1);
                dataTableCategory.Rows.Add(15, "Travel", String.Empty, 1);
                dataTableCategory.Rows.Add(16, "Business & Economics", String.Empty, 1);
                dataTableCategory.Rows.Add(17, "Reference", String.Empty, 1);
                dataTableCategory.Rows.Add(18, "Non-Classifiable", String.Empty, 1);

                dataSet.Tables.Add(dataTableCategory);


                DataTable dataTableBookCategory = new DataTable("BookCategory");
                DataColumn dataColumnBookCategoryBookId = new DataColumn { ColumnName = "BookId", DataType = Type.GetType("System.Int32") };
                DataColumn dataColumnBookCategoryCategoryId = new DataColumn { ColumnName = "CategoryId", DataType = Type.GetType("System.Int32") };
                dataTableBookCategory.Columns.Add(dataColumnBookCategoryBookId);
                dataTableBookCategory.Columns.Add(dataColumnBookCategoryCategoryId);

                OleDbCommand cmdBookCategory = new OleDbCommand();
                cmdBookCategory.CommandText = "SELECT BookID FROM Book";
                cmdBookCategory.Connection = con;

                OleDbDataReader readerBookCategory = cmdBookCategory.ExecuteReader();
                while (readerBookCategory.Read())
                {
                    dataTableBookCategory.Rows.Add(
                          readerBookCategory["BookID"]
                        , 18
                    );
                }

                dataSet.Tables.Add(dataTableBookCategory);


                DataTable dataTableBookAuthor = new DataTable("BookAuthor");
                DataColumn dataColumnBookAuthorBookId = new DataColumn { ColumnName = "BookId", DataType = Type.GetType("System.Int32") };
                DataColumn dataColumnBookAuthorAuthorId = new DataColumn { ColumnName = "AuthorId", DataType = Type.GetType("System.Int32") };
                dataTableBookAuthor.Columns.Add(dataColumnBookAuthorBookId);
                dataTableBookAuthor.Columns.Add(dataColumnBookAuthorAuthorId);

                OleDbCommand cmdBookAuthor = new OleDbCommand();
                cmdBookAuthor.CommandText = "SELECT BookId, AuthorId FROM BookAuthor";
                cmdBookAuthor.Connection = con;

                OleDbDataReader readerBookAuthor = cmdBookAuthor.ExecuteReader();
                while (readerBookAuthor.Read())
                {
                    dataTableBookAuthor.Rows.Add(
                          readerBookAuthor["BookId"]
                        , readerBookAuthor["AuthorId"]
                    );
                }

                dataSet.Tables.Add(dataTableBookAuthor);


                DataTable dataTableAuthor = new DataTable("Author");

                DataColumn dataColumnAuthorId = new DataColumn { ColumnName = "ID", DataType = Type.GetType("System.Int32") };
                dataTableAuthor.Columns.Add(dataColumnAuthorId);
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "BirthDate", DataType = Type.GetType("System.DateTime") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "BirthName", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "BirthPlace", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "DateOfDeath", DataType = Type.GetType("System.DateTime") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "FirstName", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "LastName", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "Nationality", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "Notes", DataType = Type.GetType("System.String") });
                dataTableAuthor.Columns.Add(new DataColumn { ColumnName = "Photograph", DataType = Type.GetType("System.String") });

                OleDbCommand cmdAuthor = new OleDbCommand();
                cmdAuthor.CommandText = "SELECT * FROM Author";
                cmdAuthor.Connection = con;

                OleDbDataReader readerAuthor = cmdAuthor.ExecuteReader();
                while (readerAuthor.Read())
                {
                    dataTableAuthor.Rows.Add(
                          readerAuthor.GetInt32(0)
                        , readerAuthor["BirthDate"]
                        , String.Empty
                        , readerAuthor["BirthPlace"]
                        , readerAuthor["DateOfDeath"]
                        , readerAuthor["FirstName"]
                        , readerAuthor["LastName"]
                        , readerAuthor["Nationality"]
                        , readerAuthor["Notes"]
                        , String.Empty
                    );
                }

                dataSet.Tables.Add(dataTableAuthor);


                DataTable dataTableBook = new DataTable("Book");

                DataColumn dataColumnBookID = new DataColumn { ColumnName = "ID", DataType = Type.GetType("System.Int32") };
                dataTableBook.Columns.Add(dataColumnBookID);
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "CopyrightYear", DataType = Type.GetType("System.Int32") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "CoverType", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "DatePurchased", DataType = Type.GetType("System.DateTime") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "EditionNumber", DataType = Type.GetType("System.Int32") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ImageUrl", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ImageUrl2", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ImageUrl3", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ImageUrl4", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ISBNNumber", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "ListPrice", DataType = Type.GetType("System.Decimal") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "Location", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "Notes", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "Pages", DataType = Type.GetType("System.Int32") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "PlaceofPublication", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "PublisherName", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "PublishingCompany", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "PublishingYear", DataType = Type.GetType("System.Int32") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "PurchasePrice", DataType = Type.GetType("System.Decimal") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "Title", DataType = Type.GetType("System.String") });
                dataTableBook.Columns.Add(new DataColumn { ColumnName = "VolumeNumber", DataType = Type.GetType("System.Int32") });

                OleDbCommand cmdBooks = new OleDbCommand();
                cmdBooks.CommandText = "SELECT * FROM Book";
                cmdBooks.Connection = con;

                OleDbDataReader readerBooks = cmdBooks.ExecuteReader();
                while (readerBooks.Read())
                {
                    dataTableBook.Rows.Add(
                          readerBooks.GetInt32(0)
                        , readerBooks["CopyrightYear"]
                        , readerBooks["CoverType"]
                        , readerBooks["DatePurchased"]
                        , readerBooks["EditionNumber"]
                        , readerBooks["ImageUrl"]
                        , readerBooks["ImageUrl2"]
                        , readerBooks["ImageUrl3"]
                        , readerBooks["ImageUrl4"]
                        , readerBooks["ISBNNumber"]
                        , readerBooks["ListPrice"]
                        , readerBooks["ShelfNumber"]
                        , readerBooks["Notes"]
                        , readerBooks["Pages"]
                        , readerBooks["PlaceofPublication"]
                        , readerBooks["PublisherName"]
                        , readerBooks["PublishingCompany"]
                        , readerBooks["PublishingYear"]
                        , readerBooks["PurchasePrice"]
                        , readerBooks["Title"]
                        , readerBooks["VolumeNumber"]
                    );
                }
                readerBooks.Close();

                dataSet.Tables.Add(dataTableBook);

                dataSet.Relations.Add(new DataRelation("relationBookBookAuthor", dataColumnBookID, dataColumnBookAuthorBookId));
                dataSet.Relations.Add(new DataRelation("relationAuthorBookAuthor", dataColumnAuthorId, dataColumnBookAuthorAuthorId));
                dataSet.Relations.Add(new DataRelation("relationBookBookCategory", dataColumnBookID, dataColumnBookCategoryBookId));
                dataSet.Relations.Add(new DataRelation("relationCategoryBookCategory", dataColumnCategoryCategoryId, dataColumnBookCategoryCategoryId));

                dataSet.AcceptChanges();

                WriteXml(dataSet, filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed!\n{0}\n", e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion Dataset
    }
}
