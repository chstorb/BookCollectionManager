using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication
{
    using BCM.DAL;
    using BCM.Model;
    using System.Web.ModelBinding;

    public partial class BookDetails : System.Web.UI.Page
    {
        BLL.UnitOfWork unitOfWork = new BLL.UnitOfWork();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Book GetBookById([QueryString("bookID")] int bookID)
        {
            return unitOfWork.BookRepository.GetByID(bookID);
        }

        protected void buttonAddToCart_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "AddToCart":
                    {
                        int bookID = Convert.ToInt32(e.CommandArgument);
                        string url = String.Format("AddToCart.aspx?bookID={0}", bookID);
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }

        //public IQueryable<Book> GetBook(
        //                    [QueryString("bookID")] int? bookId,
        //                    [RouteData] string bookTitle)
        //{
        //    var _db = new BCM.DAL.ApplicationDbContext();
        //    IQueryable<Book> query = _db.Books;
        //    if (bookID.HasValue && bookID > 0)
        //    {
        //        query = query.Where(b => b.ID == bookID);
        //    }
        //    else if (!String.IsNullOrEmpty(bookTitle))
        //    {
        //        query = query.Where(b => String.Compare(b.Title, bookTitle) == 0);
        //    }
        //    else
        //    {
        //        query = null;
        //    }
        //    return query;
        //}
    }
}