﻿using System;
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
    
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

    }
}