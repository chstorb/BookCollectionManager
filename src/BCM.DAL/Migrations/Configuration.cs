namespace BCM.DAL.Migrations
{
    using BCM.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<BCM.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            //string pathRoot = 
                //@"E:\";
                //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //string newPath = Path.Combine(pathRoot, @"Documents\Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            //AppDomain.CurrentDomain.SetData("DataDirectory", newPath);
                        
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BCM.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            AddUserAndRole(context);
        }

        bool AddUserAndRole(ApplicationDbContext context)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            IdentityResult ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser()
            {
                UserName = "user1",
            };
            ir = um.Create(user, "Passw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;

            ir = um.AddToRole(user.Id, "canEdit");

            return ir.Succeeded;
        }
    }
}
