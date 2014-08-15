using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCM.WebFormsApplication.BLL
{
    using BCM.Model;
    using System.ComponentModel;

    [DataObject]
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(BCM.DAL.ApplicationDbContext context)
            : base(context)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public bool AddBook(string Title, string Notes, string Price, string CategoryId, string ImageUrl)
        {
            Book book = new Book();
            book.Title = Title;
            book.Notes = Notes;
            book.ListPrice = Convert.ToDecimal(Price);
            book.ImageUrl = ImageUrl;
            
            Category category = context.Categories.Find(Convert.ToInt32(CategoryId));
            book.Categories.Add(category);
                
            // Add product to DB.
            context.Books.Add(book);
            context.SaveChanges();

            return true;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IQueryable<Book> GetBooks()
        {
            return context.Books;
        }
        
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IEnumerable<Book> GetBooksByCategoryId(int categoryId)
        {
            IEnumerable<Book> query = context.Categories.Include("Books")
                .Where(c => c.ID == categoryId)
                .SelectMany(c => c.Books);
            return query;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Book GetBookById(int bookID)
        {
            return this.GetByID(bookID); 
        }
    }
}