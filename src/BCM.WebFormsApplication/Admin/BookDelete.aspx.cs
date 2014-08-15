using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication.Admin
{
    using BCM.Model;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Web.ModelBinding;

    public partial class BookDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["BookAction"];
            if (productAction == "remove")
            {
                LabelRemoveStatus.Text = "Book removed!";
            }
        }

        public IQueryable<Book> GetBook([QueryString("bookID")] int? bookID)
        {
            var _db = new BCM.DAL.ApplicationDbContext();
            IQueryable<Book> query = _db.Books;
            if (bookID.HasValue && bookID > 0)
            {
                query = query.Where(b => b.ID == bookID);
            }
            else
            {
                query = null;
            }
            return query;
        }

        public IQueryable<Book> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new BCM.DAL.ApplicationDbContext();
            IQueryable<Category> query = _db.Categories.Include("Books");
            if (categoryId.HasValue && categoryId > 1)
            {
                query = query.Where(c => c.ID == categoryId);
            }
            IQueryable<Book> books = (IQueryable<Book>)query.SelectMany(c => c.Books);
            return books;
        }

        protected void RemoveBookButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt16(DropDownRemoveBook.SelectedValue);
            Delete(bookID);
        }

        public void Delete(int bookID)
        {
            var _db = new BCM.DAL.ApplicationDbContext();

            //var item = new Book { ID = bookID };
            //_db.Entry(item).State = EntityState.Deleted;
            //try
            //{
            //    _db.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    ModelState.AddModelError("",
            //      String.Format("Item with id {0} no longer exists in the database.", bookID));
            //}
            
            var item = (from c in _db.Books where c.ID == bookID select c).FirstOrDefault();
            if (item != null)
            {
                _db.Books.Remove(item);
                _db.SaveChanges();

                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?BookAction=remove");
            }
            else
            {
                LabelRemoveStatus.Text = "Unable to locate book.";
            }        
        }
    }
}