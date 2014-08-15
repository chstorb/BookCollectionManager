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
    
    public partial class BookIndex : System.Web.UI.Page
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
            return unitOfWork.BookRepository.GetBooks();
        }

        protected void buttonCreateNew_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Create":
                    {
                        string url = "~/Admin/BookCreate.aspx";
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }

        protected void linkButtonBookEdit_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Edit":
                    {
                        int bookID = Convert.ToInt32(e.CommandArgument);
                        string url = String.Format("~/Admin/BookEdit.aspx?bookID={0}", bookID);
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }

        protected void linkButtonBookDetails_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Details":
                    {
                        int bookID = Convert.ToInt32(e.CommandArgument);
                        string url = String.Format("~/Admin/BookDetails.aspx?bookID={0}", bookID);
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }

        protected void linkButtonBookDelete_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    {
                        int bookID = Convert.ToInt32(e.CommandArgument);
                        string url = String.Format("~/Admin/BookDelete.aspx?bookID={0}", bookID);
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}