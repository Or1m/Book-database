namespace ProjektPJ2
{
    partial class mainForm
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
            this.mainList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bestseller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttAddBook = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.bestSell = new System.Windows.Forms.Label();
            this.bestBox = new System.Windows.Forms.ComboBox();
            this.buttEdit = new System.Windows.Forms.Button();
            this.buttRemove = new System.Windows.Forms.Button();
            this.buttSave = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainList
            // 
            this.mainList.AllowColumnReorder = true;
            this.mainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Author,
            this.NumOfPages,
            this.Bestseller});
            this.mainList.FullRowSelect = true;
            this.mainList.HideSelection = false;
            this.mainList.Location = new System.Drawing.Point(259, 12);
            this.mainList.Name = "mainList";
            this.mainList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainList.Size = new System.Drawing.Size(524, 419);
            this.mainList.TabIndex = 0;
            this.mainList.UseCompatibleStateImageBehavior = false;
            this.mainList.View = System.Windows.Forms.View.Details;
            this.mainList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainList_MouseMove);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 150;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 150;
            // 
            // NumOfPages
            // 
            this.NumOfPages.Text = "Number of pages";
            this.NumOfPages.Width = 100;
            // 
            // Bestseller
            // 
            this.Bestseller.Text = "Bestseller";
            // 
            // buttAddBook
            // 
            this.buttAddBook.Location = new System.Drawing.Point(12, 12);
            this.buttAddBook.Name = "buttAddBook";
            this.buttAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttAddBook.TabIndex = 1;
            this.buttAddBook.Text = "Add book";
            this.buttAddBook.UseVisualStyleBackColor = true;
            this.buttAddBook.Click += new System.EventHandler(this.ButtAddBook_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(107, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 2;
            this.titleBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TitleBox_KeyUp);
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(107, 54);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 20);
            this.authorBox.TabIndex = 3;
            this.authorBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthorBox_KeyUp);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(107, 90);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 20);
            this.numBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of pages";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(3, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Tag = "";
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.bestSell);
            this.panelAdd.Controls.Add(this.bestBox);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.titleBox);
            this.panelAdd.Controls.Add(this.authorBox);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.numBox);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(12, 41);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(220, 207);
            this.panelAdd.TabIndex = 10;
            this.panelAdd.Visible = false;
            // 
            // bestSell
            // 
            this.bestSell.AutoSize = true;
            this.bestSell.Location = new System.Drawing.Point(9, 130);
            this.bestSell.Name = "bestSell";
            this.bestSell.Size = new System.Drawing.Size(52, 13);
            this.bestSell.TabIndex = 11;
            this.bestSell.Text = "Bestseller";
            // 
            // bestBox
            // 
            this.bestBox.FormattingEnabled = true;
            this.bestBox.Items.AddRange(new object[] {
            "Yes",
            "No",
            "n/a"});
            this.bestBox.Location = new System.Drawing.Point(107, 127);
            this.bestBox.Name = "bestBox";
            this.bestBox.Size = new System.Drawing.Size(100, 21);
            this.bestBox.TabIndex = 10;
            // 
            // buttEdit
            // 
            this.buttEdit.Enabled = false;
            this.buttEdit.Location = new System.Drawing.Point(93, 12);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(75, 23);
            this.buttEdit.TabIndex = 11;
            this.buttEdit.Text = "Edit book";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.ButtEdit_Click);
            // 
            // buttRemove
            // 
            this.buttRemove.Enabled = false;
            this.buttRemove.Location = new System.Drawing.Point(174, 12);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(75, 23);
            this.buttRemove.TabIndex = 12;
            this.buttRemove.Text = "Remove";
            this.buttRemove.UseVisualStyleBackColor = true;
            this.buttRemove.Click += new System.EventHandler(this.ButtRemove_Click);
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(12, 408);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(75, 23);
            this.buttSave.TabIndex = 13;
            this.buttSave.Text = "Save to file";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.ButtSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.buttRemove);
            this.Controls.Add(this.buttEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.buttAddBook);
            this.Controls.Add(this.mainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.Text = "Books";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mainList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader NumOfPages;
        private System.Windows.Forms.ColumnHeader Bestseller;
        private System.Windows.Forms.Button buttAddBook;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.ComboBox bestBox;
        private System.Windows.Forms.Label bestSell;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Button buttRemove;
        private System.Windows.Forms.Button buttSave;
    }
}

