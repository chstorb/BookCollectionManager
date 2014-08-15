using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication.Admin
{
    using BCM.Model;
    using System.Web.ModelBinding;

    public partial class BookDetail : System.Web.UI.Page
    {
        BLL.UnitOfWork unitOfWork = new BLL.UnitOfWork();

        protected void Page_Load(object sender, EventArgs e)
        {
            formViewBookDetails.ChangeMode(FormViewMode.ReadOnly);
        }

        public Book GetBookById([QueryString("bookID")] int bookID)
        {
            return unitOfWork.BookRepository.GetByID(bookID);
        }
    }
}
