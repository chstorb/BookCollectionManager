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
    using BCM.WebFormsApplication.Logic;
    using System.IO;

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string pathRoot =
                @"E:\";
            //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string newPath = Path.Combine(pathRoot, @"Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            AppDomain.CurrentDomain.SetData(Common.Constants.DataDirectory, newPath);

            BCM.DAL.ApplicationDbContext context = new BCM.DAL.ApplicationDbContext();
            BCM.DAL.Migrations.RoleActions.createAdmin(context);
            BCM.DAL.Migrations.RoleActions.createUserAndRole(context);

            // Add Routes.
            //RegisterCustomRoutes(RouteTable.Routes);
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