using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BCM.WebFormsApplication
{
    using BCM.Common;
    using BCM.DAL;
    using BCM.DAL.Migrations;
    using BCM.WebFormsApplication.BLL;
    using System.Data.Entity;
    using System.IO;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Add custom routes
            // RegisterCustomRoutes(RouteTable.Routes);

            string pathRoot =
                @"E:\";
            //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string newPath = Path.Combine(pathRoot, @"Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            AppDomain.CurrentDomain.SetData(Common.Constants.DataDirectory, newPath);

            // Automatic database updates on startup
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            // Add user
            ApplicationDbContext context = new ApplicationDbContext();
            RoleActions.createAdmin(context);
            RoleActions.createUserAndRole(context);
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs.

            // Get last error from the server
            Exception exc = Server.GetLastError();

            if (exc is HttpUnhandledException)
            {
                if (exc.InnerException != null)
                {
                    exc = new Exception(exc.InnerException.Message);
                    Server.Transfer("~/ErrorPage.aspx?handler=Application_Error%20-%20Global.asax", true);
                }
            }
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "BooksByCategoryRoute",
                "Category/{categoryName}",
                "~/BookList.aspx"
            );
            routes.MapPageRoute(
                "BookByTitleRoute",
                "Book/{bookTitle}",
                "~/BookDetails.aspx"
            );
        }
    }
}