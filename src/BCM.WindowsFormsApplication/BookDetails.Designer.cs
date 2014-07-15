namespace BCM.WindowsFormsApplication
{
    partial class BookDetails
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBookId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCagtegories = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCopyrightYear = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelISBNNumber = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPublishingCompany = new System.Windows.Forms.Label();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelPublishingYear = new System.Windows.Forms.Label();
            this.labelPlaceOfPublication = new System.Windows.Forms.Label();
            this.labelVolumeNumber = new System.Windows.Forms.Label();
            this.labelEditionNumber = new System.Windows.Forms.Label();
            this.labelCoverType = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(18, 23);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(61, 17);
            this.labelBookId.TabIndex = 0;
            this.labelBookId.Text = "Book ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(18, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 17);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Titel:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 3;
            // 
            // labelCagtegories
            // 
            this.labelCagtegories.AutoSize = true;
            this.labelCagtegories.Location = new System.Drawing.Point(18, 85);
            this.labelCagtegories.Name = "labelCagtegories";
            this.labelCagtegories.Size = new System.Drawing.Size(80, 17);
            this.labelCagtegories.TabIndex = 4;
            this.labelCagtegories.Text = "Categories:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 82);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelCopyrightYear
            // 
            this.labelCopyrightYear.AutoSize = true;
            this.labelCopyrightYear.Location = new System.Drawing.Point(18, 188);
            this.labelCopyrightYear.Name = "labelCopyrightYear";
            this.labelCopyrightYear.Size = new System.Drawing.Size(106, 17);
            this.labelCopyrightYear.TabIndex = 6;
            this.labelCopyrightYear.Text = "Copyright Year:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // labelISBNNumber
            // 
            this.labelISBNNumber.AutoSize = true;
            this.labelISBNNumber.Location = new System.Drawing.Point(18, 222);
            this.labelISBNNumber.Name = "labelISBNNumber";
            this.labelISBNNumber.Size = new System.Drawing.Size(98, 17);
            this.labelISBNNumber.TabIndex = 8;
            this.labelISBNNumber.Text = "ISBN-Number:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // labelPublishingCompany
            // 
            this.labelPublishingCompany.AutoSize = true;
            this.labelPublishingCompany.Location = new System.Drawing.Point(18, 250);
            this.labelPublishingCompany.Name = "labelPublishingCompany";
            this.labelPublishingCompany.Size = new System.Drawing.Size(140, 17);
            this.labelPublishingCompany.TabIndex = 10;
            this.labelPublishingCompany.Text = "Publishing Company:";
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(18, 281);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(112, 17);
            this.labelPublisherName.TabIndex = 11;
            this.labelPublisherName.Text = "Publisher Name:";
            // 
            // labelPublishingYear
            // 
            this.labelPublishingYear.AutoSize = true;
            this.labelPublishingYear.Location = new System.Drawing.Point(18, 312);
            this.labelPublishingYear.Name = "labelPublishingYear";
            this.labelPublishingYear.Size = new System.Drawing.Size(111, 17);
            this.labelPublishingYear.TabIndex = 12;
            this.labelPublishingYear.Text = "Publishing Year:";
            // 
            // labelPlaceOfPublication
            // 
            this.labelPlaceOfPublication.AutoSize = true;
            this.labelPlaceOfPublication.Location = new System.Drawing.Point(18, 343);
            this.labelPlaceOfPublication.Name = "labelPlaceOfPublication";
            this.labelPlaceOfPublication.Size = new System.Drawing.Size(136, 17);
            this.labelPlaceOfPublication.TabIndex = 13;
            this.labelPlaceOfPublication.Text = "Place of Publication:";
            // 
            // labelVolumeNumber
            // 
            this.labelVolumeNumber.AutoSize = true;
            this.labelVolumeNumber.Location = new System.Drawing.Point(18, 376);
            this.labelVolumeNumber.Name = "labelVolumeNumber";
            this.labelVolumeNumber.Size = new System.Drawing.Size(113, 17);
            this.labelVolumeNumber.TabIndex = 14;
            this.labelVolumeNumber.Text = "Volume Number:";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Location = new System.Drawing.Point(18, 404);
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(109, 17);
            this.labelEditionNumber.TabIndex = 15;
            this.labelEditionNumber.Text = "Edition Number:";
            // 
            // labelCoverType
            // 
            this.labelCoverType.AutoSize = true;
            this.labelCoverType.Location = new System.Drawing.Point(423, 88);
            this.labelCoverType.Name = "labelCoverType";
            this.labelCoverType.Size = new System.Drawing.Size(85, 17);
            this.labelCoverType.TabIndex = 16;
            this.labelCoverType.Text = "Cover Type:";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(423, 119);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(52, 17);
            this.labelPages.TabIndex = 17;
            this.labelPages.Text = "Pages:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(423, 150);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 17);
            this.labelLocation.TabIndex = 18;
            this.labelLocation.Text = "Location:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(161, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(161, 281);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(161, 312);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(161, 343);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(161, 370);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(161, 399);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(521, 88);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(521, 117);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(521, 150);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 27;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelCoverType);
            this.Controls.Add(this.labelEditionNumber);
            this.Controls.Add(this.labelVolumeNumber);
            this.Controls.Add(this.labelPlaceOfPublication);
            this.Controls.Add(this.labelPublishingYear);
            this.Controls.Add(this.labelPublisherName);
            this.Controls.Add(this.labelPublishingCompany);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelISBNNumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCopyrightYear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCagtegories);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBookId);
            this.Name = "BookDetails";
            this.Size = new System.Drawing.Size(878, 465);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCagtegories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCopyrightYear;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelISBNNumber;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPublishingCompany;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelPublishingYear;
        private System.Windows.Forms.Label labelPlaceOfPublication;
        private System.Windows.Forms.Label labelVolumeNumber;
        private System.Windows.Forms.Label labelEditionNumber;
        private System.Windows.Forms.Label labelCoverType;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}
