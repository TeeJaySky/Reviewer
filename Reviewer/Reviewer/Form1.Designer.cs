﻿namespace Reviewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bsr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.forward = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.MaybeButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.LoadWebpage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.webBrowser, 2);
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 2);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1006, 702);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 772);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Term";
            // 
            // searchTerm
            // 
            this.searchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTerm.Location = new System.Drawing.Point(187, 769);
            this.searchTerm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(822, 22);
            this.searchTerm.TabIndex = 4;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Location = new System.Drawing.Point(187, 827);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(822, 22);
            this.title.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 830);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // category
            // 
            this.category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.category.Location = new System.Drawing.Point(187, 798);
            this.category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(822, 22);
            this.category.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 801);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // bsr
            // 
            this.bsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bsr.Location = new System.Drawing.Point(187, 740);
            this.bsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsr.Name = "bsr";
            this.bsr.Size = new System.Drawing.Size(822, 22);
            this.bsr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 743);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "BSR";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.forward, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Back, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.NoButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.MaybeButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.searchTerm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bsr, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.title, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.category, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.YesButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProductImage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadWebpage, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.90632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.376906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263042F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1840, 918);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // forward
            // 
            this.forward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forward.Location = new System.Drawing.Point(4, 857);
            this.forward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forward.Name = "forward";
            this.tableLayoutPanel1.SetRowSpan(this.forward, 2);
            this.forward.Size = new System.Drawing.Size(176, 57);
            this.forward.TabIndex = 17;
            this.forward.Text = "Forward";
            this.forward.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.Location = new System.Drawing.Point(188, 857);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.tableLayoutPanel1.SetRowSpan(this.Back, 2);
            this.Back.Size = new System.Drawing.Size(820, 57);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoButton.Location = new System.Drawing.Point(1016, 857);
            this.NoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoButton.Name = "NoButton";
            this.tableLayoutPanel1.SetRowSpan(this.NoButton, 2);
            this.NoButton.Size = new System.Drawing.Size(820, 57);
            this.NoButton.TabIndex = 15;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // MaybeButton
            // 
            this.MaybeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaybeButton.Location = new System.Drawing.Point(1016, 799);
            this.MaybeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaybeButton.Name = "MaybeButton";
            this.tableLayoutPanel1.SetRowSpan(this.MaybeButton, 2);
            this.MaybeButton.Size = new System.Drawing.Size(820, 50);
            this.MaybeButton.TabIndex = 14;
            this.MaybeButton.Text = "Maybe";
            this.MaybeButton.UseVisualStyleBackColor = true;
            this.MaybeButton.Click += new System.EventHandler(this.MaybeButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesButton.Location = new System.Drawing.Point(1016, 741);
            this.YesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YesButton.Name = "YesButton";
            this.tableLayoutPanel1.SetRowSpan(this.YesButton, 2);
            this.YesButton.Size = new System.Drawing.Size(820, 50);
            this.YesButton.TabIndex = 13;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // ProductImage
            // 
            this.ProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductImage.Location = new System.Drawing.Point(1015, 3);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(822, 700);
            this.ProductImage.TabIndex = 18;
            this.ProductImage.TabStop = false;
            // 
            // LoadWebpage
            // 
            this.LoadWebpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadWebpage.Location = new System.Drawing.Point(187, 709);
            this.LoadWebpage.Name = "LoadWebpage";
            this.LoadWebpage.Size = new System.Drawing.Size(822, 25);
            this.LoadWebpage.TabIndex = 19;
            this.LoadWebpage.Text = "LoadWebpage";
            this.LoadWebpage.UseVisualStyleBackColor = true;
            this.LoadWebpage.Click += new System.EventHandler(this.LoadWebpage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 918);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button MaybeButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Button LoadWebpage;
    }
}

