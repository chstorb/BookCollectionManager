using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.DAL
{
    using BCM.Common;
    using BCM.DAL;
    using BCM.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    /// <summary>
    /// ApplicationDbContext class.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().ToTable(BCM.Common.Constants.TablePrefix + "Roles");
            modelBuilder.Entity<IdentityUserClaim>().ToTable(BCM.Common.Constants.TablePrefix + "UserClaims");
            modelBuilder.Entity<IdentityUserLogin>().ToTable(BCM.Common.Constants.TablePrefix + "UserLogins");
            modelBuilder.Entity<IdentityUserRole>().ToTable(BCM.Common.Constants.TablePrefix + "UserRoles");
            modelBuilder.Entity<IdentityUser>().ToTable(BCM.Common.Constants.TablePrefix + "Users");
            modelBuilder.Entity<ApplicationUser>().ToTable(BCM.Common.Constants.TablePrefix + "Users");

            modelBuilder.Entity<Book>()
                .HasMany(a => a.Authors)
                .WithMany(a => a.Books)
                .Map(m =>
                {
                    m.ToTable(BCM.Common.Constants.TablePrefix + "BookAuthor");
                    m.MapLeftKey("BookId");
                    m.MapRightKey("AuthorId");
                });

            modelBuilder.Entity<Book>()
                .HasMany(c => c.Categories)
                .WithMany(c => c.Books)
                .Map(m =>
                {
                    m.ToTable(BCM.Common.Constants.TablePrefix + "BookCategory");
                    m.MapLeftKey("BookId");
                    m.MapRightKey("CategoryId");
                });
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }

    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }
    }
}
