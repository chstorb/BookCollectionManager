using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCM.WebFormsApplication.BLL
{
    using BCM.Model;

    public class UnitOfWork : IDisposable
    {
        private BCM.DAL.ApplicationDbContext context = new BCM.DAL.ApplicationDbContext();
        private BookRepository bookRepository;
        private GenericRepository<Category> categoryRepository;

        public BookRepository BookRepository
        {
            get
            {
                if (this.bookRepository == null)
                {
                    this.bookRepository = new BookRepository(context);
                }
                return bookRepository;
            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(context);
                }
                return categoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}