using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM.WindowsFormsApplication
{
    using System.IO;
    using System.Reflection;

    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pathRoot =
                //@"E:\";
                //Path.GetPathRoot(Assembly.GetExecutingAssembly().Location);
                //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string newPath = Path.Combine(pathRoot, @"Documents\Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", newPath);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
