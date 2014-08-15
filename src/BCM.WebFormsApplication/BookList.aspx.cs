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
    using System.Web.Routing;

    public partial class BookList : System.Web.UI.Page
    {
        BLL.UnitOfWork unitOfWork = new BLL.UnitOfWork();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IEnumerable<Book> GetBooks([QueryString("categoryID")] int? categoryID)
        {
            if (categoryID.HasValue && categoryID > 1)
            {
                return unitOfWork.BookRepository.GetBooksByCategoryId(categoryID ?? 1);
            }            
            return unitOfWork.BookRepository.Get();
        }

        //public IQueryable<Book> GetBooks([QueryString("id")] int? categoryId,
        //                                 [RouteData] string categoryName)
        //{
        //    IQueryable<Category> query = db.Categories.Include("Books");
        //    if (categoryId.HasValue && categoryId > 1)
        //    {
        //        query = query.Where(c => c.ID == categoryId);
        //    }

        //    if (!String.IsNullOrEmpty(categoryName))
        //    {
        //        query = query.Where(c => String.Compare(c.Name, categoryName) == 0);
        //    }

        //    IQueryable<Book> books = (IQueryable<Book>)query.SelectMany(c => c.Books);
        //    return books;
        //}

        public string Truncate(string text, int length)
        {
            if (text.Length > length)
            {
                return String.Format("{0}...", text.Substring(0, length));
            }
            return text;
        }
    }
}