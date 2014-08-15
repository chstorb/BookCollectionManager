using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCM.WebFormsApplication.BLL
{
    using BCM.Model;
    using System.ComponentModel;

    [DataObject]
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(BCM.DAL.ApplicationDbContext context)
            : base(context)
        {
        }
    }
}