using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Forms.Extensions
{
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class DataPictureBox : PictureBox
    {
        #region Fields

        private string imagePath;

        private string imageFolder;

        #endregion Fields

        #region Events

        public event EventHandler ImagePathChanged;

        #endregion Events

        #region Properties

        [Bindable(false),
            Category("Appearance")]
        public string ImageFolder 
        { 
            get
            {
                return this.imageFolder;
            }
            set
            {
                this.imageFolder = value;
            }
        }

        [Bindable(true), 
            Category("Appearance")]
        public string ImagePath
        {
            get 
            { 
                return this.imagePath; 
            }
            set
            {
                if (value != imagePath)
                {
                    if (value == null)
                    {
                        this.Image = null;
                        this.ImagePath = String.Empty;
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(this.imageFolder))
                        {
                            imagePath = Path.Combine(this.imageFolder, value);
                        }
                        else
                        {
                            this.imagePath = value;
                        }
                        if (File.Exists(imagePath))
                        {
                            UpdateImage();
                        }
                        if (ImagePathChanged != null)
                        {
                            ImagePathChanged((object)this, new EventArgs());
                        }
                    }
                }
            }
        }

        #endregion Properties

        #region Methods

        private void UpdateImage()
        {
            try
            {
                this.Image = (Image)new Bitmap(this.ImagePath);
            }
            catch
            {
                this.Image = null;
            }
        }

        #endregion Methods

    }
}
