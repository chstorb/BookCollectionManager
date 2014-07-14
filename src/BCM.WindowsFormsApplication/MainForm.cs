using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM.WindowsFormsApplication
{
    using BCM.DAL;

    public partial class MainForm : Form
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        public MainForm()
        {            
            InitializeComponent();

            this.treeViewAuthors.DbContext = this.dbContext;
            this.treeViewBooks.DbContext = this.dbContext;
            this.treeViewCategories.DbContext = this.dbContext;
            this.bookList.DbContext = this.dbContext;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if ((this.Site != null) && (this.Site.DesignMode))
                return;
            //
            // panelStartup 
            //
            this.panelStartup.Visible = true;
            this.panelStartup.Dock = DockStyle.Fill;
            //
            // toolStripStatusLabel2
            //
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            // 
            // treeViewAuthors
            // 
            this.treeViewAuthors.Visible = false;
            // 
            // treeViewBooks
            // 
            this.treeViewBooks.Visible = false;
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.Visible = true;
            this.treeViewCategories.Dock = DockStyle.Fill;
            //
            // bookList
            //            
            this.bookList.Visible = true;
            this.bookList.Dock = DockStyle.Fill;

            this.Text = Application.ProductName;

            this.labelInfo.Text = Application.ProductName;
        }

        private void buttonSelectAuthors_Click(object sender, EventArgs e)
        {
            this.labelInfo.Text = "Authors";
            this.authorsList_Show();
        }
        
        private void buttonSelectBooks_Click(object sender, EventArgs e)
        {
            this.labelInfo.Text = "Books";
            this.bookList_Show();
        }

        private void buttonSelectCategories_Click(object sender, EventArgs e)
        {
            this.labelInfo.Text = "Categories";
            this.categoriesList_Show();
        }

        private void authorsList_Show()
        {           
            //if (this.authorsList.Visible)
            //    return;

            this.SuspendLayout();

            //if (this.bookList.Visible)
            //    this.bookList.Visible = false;            

            this.ResumeLayout();
        }

        private void bookList_Show()
        {
            if (this.bookList.Visible)
                return;

            this.SuspendLayout();

            if (!this.bookList.Visible)
            {
                this.bookList.Visible = true;
                this.bookList.Dock = DockStyle.Fill;
            }

            this.ResumeLayout();
        }

        private void categoriesList_Show()
        {
            //if (this.categoriesList.Visible)
            //    return;

            this.SuspendLayout();

            //if (this.bookList.Visible)
            //    this.bookList.Visible = false;            

            this.ResumeLayout();
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //this.bookList.Filter = String.Format("ID={0}", e.Node.Tag.ToString());
            this.bookList.FilterByCategoryId(int.Parse(e.Node.Tag.ToString()));
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}\n\nVersion {1}", Application.ProductName, Application.ProductVersion), 
                Application.ProductName,
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void splitContainerNav_Resize(object sender, EventArgs e)
        {
            if (this.Site != null && this.Site.DesignMode)
                return;

            if (this.splitContainerNav.Height - this.splitContainerNav.SplitterDistance - 4 != 150)
                this.splitContainerNav.SplitterDistance = this.splitContainerNav.Height - 157;
        }

        private void splitContainerNav_Panel1_Resize(object sender, EventArgs e)
        {
            if (this.Site != null && this.Site.DesignMode)
                return;

            if (this.splitContainerNav.Height - this.splitContainerNav.SplitterDistance - 4 != 150)
                this.splitContainerNav.SplitterDistance = this.splitContainerNav.Height - 157;
        }

        private void splitContainerNav_Panel2_Resize(object sender, EventArgs e)
        {
            if (this.Site != null && this.Site.DesignMode)
                return;

            if (this.splitContainerNav.Height - this.splitContainerNav.SplitterDistance - 4 != 150)
                this.splitContainerNav.SplitterDistance = this.splitContainerNav.Height - 157;
        }
    }
}
