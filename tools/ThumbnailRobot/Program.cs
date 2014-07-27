using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailRobot
{
    using System.Drawing;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                throw new ArgumentException();
            }

            string sourceDirectory = args[0];
            string targetDirectory = args[1];

            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            ConvertAll(diSource, diTarget);
        }

        private static void ConvertAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Convert and copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {                
                Console.WriteLine(@"Converting {0}\{1}", target.FullName, fi.Name);
                
                Image image = Image.FromFile(fi.FullName);
                Image thumbnail = image.ToThumbnail();                              
                //fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                thumbnail.Save(Path.Combine(target.ToString(), fi.Name));
            }

            // Copy each subdirectory using recursion.
            //foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            //{
            //    DirectoryInfo nextTargetSubDir =
            //        target.CreateSubdirectory(diSourceSubDir.Name);
            //    ConvertAll(diSourceSubDir, nextTargetSubDir);
            //}
        }
    }
}
