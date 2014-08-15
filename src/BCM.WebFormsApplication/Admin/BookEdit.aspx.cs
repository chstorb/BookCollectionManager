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

    public partial class BookEdit : System.Web.UI.Page
    {
        BLL.UnitOfWork unitOfWork = new BLL.UnitOfWork();

        protected void Page_Load(object sender, EventArgs e)
        {
            formViewBookEdit.ChangeMode(FormViewMode.Edit);
        }

        public Book GetBookById([QueryString("bookID")] int bookID)
        {
            return unitOfWork.BookRepository.GetByID(bookID);
        }

        public IEnumerable<Category> GetCategories()
        {
            return unitOfWork.CategoryRepository.Get();
        }

        public void UpdateBook([QueryString("bookID")]int? bookID)
        {             
            Book book = unitOfWork.BookRepository.GetByID(bookID);
            if (book == null)
            {
                ModelState.AddModelError("Error", String.Format("Item with id {0} was not found!", bookID));
                return;
            }

            TryUpdateModel(book);

            if (ModelState.IsValid)
            { 
                // Update model in database
                try
                {
                    unitOfWork.Save();
                    // ErrorLabel.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    //ErrorLabel.Text = ex.Message;
                }
            }
        }

        public void UpdateBook2(Book book)
        {
            if (book != null)
            {                
                try
                {
                    var originalBook = unitOfWork.BookRepository.GetByID(book.ID);
                    originalBook.ImageUrl = book.ImageUrl;
                    originalBook.ListPrice = book.ListPrice;
                    originalBook.Notes = book.Notes;
                    originalBook.Title = book.Title;

                    unitOfWork.Save();
                    //ErroLabel.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    //ErrorLabel.Text = ex.Message;
                }
            }
        }

        protected void linkButtonBack_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Back":
                    {
                        string url = "~/Admin/BookIndex.aspx";
                        Response.Redirect(url);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}