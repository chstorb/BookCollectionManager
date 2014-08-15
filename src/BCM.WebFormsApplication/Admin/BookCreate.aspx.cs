using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BCM.WebFormsApplication.Admin
{
    using BCM.Model;
    using BCM.WebFormsApplication.BLL;

    public partial class BookCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string productAction = Request.QueryString["BookAction"];
            //if (productAction == "add")
            //{
            //    LabelAddStatus.Text = "Book added!";
            //}
            formViewBookCreate.ChangeMode(FormViewMode.Insert);
        }

        public void Create(/*[Control("CategoryDropDown")]*/ int? categoryId)
        {
            if (categoryId == null || categoryId == 0)
            {
                //ErrorLabel.Text = "Select a category before iserting a new book!";
                return;
            }

            var book = new Book();

            TryUpdateModel(book);
            
            var _db = new BCM.DAL.ApplicationDbContext();

            //book.Categories == _db.Categories.Find(categoryId);
            //book.Title = 

            if (ModelState.IsValid)
            { 
            }
        }

        //protected void AddBookButton_Click(object sender, EventArgs e)
        //{
        //    Boolean fileOK = false;
        //    String path = Server.MapPath("~/Catalog/Images/");
        //    if (BookImage.HasFile)
        //    {
        //        String fileExtension = System.IO.Path.GetExtension(BookImage.FileName).ToLower();
        //        String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
        //        for (int i = 0; i < allowedExtensions.Length; i++)
        //        {
        //            if (fileExtension == allowedExtensions[i])
        //            {
        //                fileOK = true;
        //            }
        //        }
        //    }

        //    if (fileOK)
        //    {
        //        try
        //        {
        //            // Save to Images folder.
        //            BookImage.PostedFile.SaveAs(path + BookImage.FileName);
        //            // Save to Images/Thumbs folder.
        //            BookImage.PostedFile.SaveAs(path + "Thumbs/" + BookImage.FileName);
        //        }
        //        catch (Exception ex)
        //        {
        //            LabelAddStatus.Text = ex.Message;
        //        }

        //        // Add product data to DB.
        //        AddBooks books = new AddBooks();
        //        bool addSuccess = books.AddBook(AddBookTitle.Text, AddBookNotes.Text,
        //            AddBookPrice.Text, DropDownAddCategory.SelectedValue, BookImage.FileName);
        //        if (addSuccess)
        //        {
        //            // Reload the page.
        //            string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
        //            Response.Redirect(pageUrl + "?BookAction=add");
        //        }
        //        else
        //        {
        //            LabelAddStatus.Text = "Unable to add new book to database.";
        //        }
        //    }
        //    else
        //    {
        //        LabelAddStatus.Text = "Unable to accept file type.";
        //    }
        //}

        public IQueryable GetCategories()
        {
            var _db = new BCM.DAL.ApplicationDbContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetBooks()
        {
            var _db = new BCM.DAL.ApplicationDbContext();
            IQueryable query = _db.Books;
            return query;
        }

        public void formViewBookCreate_InsertItem()
        {
            var item = new BCM.Model.Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes 
                using (BCM.DAL.ApplicationDbContext db = new BCM.DAL.ApplicationDbContext())
                {
                    db.Books.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void formViewBookCreate_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Admin/BookIndex");
        }

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/BookIndex");
        }
    }
}