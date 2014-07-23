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
        }
    }
}