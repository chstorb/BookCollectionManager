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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Book> GetBook([QueryString("bookID")] int? bookId)
        {
            var _db = new BCM.DAL.ApplicationDbContext();
            IQueryable<Book> query = _db.Books;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(b => b.ID == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }

    }
}