using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailRobot
{
    using System.Drawing;

    public static class ImageExtensions
    {
        public static bool ThumbnailCallback()
        {
            return true;
        }
        
        public static Image ToThumbnail(this Image image)
        {
            Image.GetThumbnailImageAbort callback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            return image.GetThumbnailImage(100, 100, callback, new IntPtr());                        
        }
    }
}
