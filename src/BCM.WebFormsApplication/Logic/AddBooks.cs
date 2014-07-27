using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCM.WebFormsApplication.Logic
{
    using BCM.Model;

    public class AddBooks
    {
        public bool AddBook(string Title, string Notes, string Price, string CategoryId, string ImageUrl)
        {
            Book book = new Book();
            book.Title = Title;
            book.Notes = Notes;
            book.ListPrice = Convert.ToDecimal(Price);
            book.ImageUrl = ImageUrl;
            
            using (BCM.DAL.ApplicationDbContext _db = new BCM.DAL.ApplicationDbContext())
            {
                Category category = _db.Categories.Find(Convert.ToInt32(CategoryId));
                book.Categories.Add(category);
                
                // Add product to DB.
                _db.Books.Add(book);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}