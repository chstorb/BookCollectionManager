using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM.WindowsFormsApplication
{
    using System.IO;
    using System.Reflection;
    using System.Threading;

    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pathRoot =
                @"E:\";
                //Path.GetPathRoot(Assembly.GetExecutingAssembly().Location);
                //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string newPath = Path.Combine(pathRoot, @"Visual Studio 2013\codeplex\bcm\src\BCM.DAL\App_Data");
            AppDomain.CurrentDomain.SetData(Common.Constants.DataDirectory, newPath);

            Mutex mutex = new Mutex(false, "BCM");
            if (mutex.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("An Instance of Book Collection Manager is already running!", 
                    "Book Collection Manager", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
