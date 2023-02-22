namespace LibraryManager
{
    partial class BorrowBookForm
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
            this.components = new System.ComponentModel.Container();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.libraryManagerDataSet = new LibraryManager.LibraryManagerDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibraryManager.LibraryManagerDataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borrowButton = new System.Windows.Forms.Button();
            this.seeBorrowedBooks = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(57, 46);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(304, 21);
            this.bookComboBox.TabIndex = 0;
            this.bookComboBox.SelectedIndexChanged += new System.EventHandler(this.bookComboBox_SelectedIndexChanged);
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(57, 108);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(304, 21);
            this.clientComboBox.TabIndex = 1;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.clientComboBox_SelectedIndexChanged);
            // 
            // libraryManagerDataSet
            // 
            this.libraryManagerDataSet.DataSetName = "LibraryManagerDataSet";
            this.libraryManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryManagerDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryManagerDataSet;
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(149, 164);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(123, 51);
            this.borrowButton.TabIndex = 2;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // seeBorrowedBooks
            // 
            this.seeBorrowedBooks.Location = new System.Drawing.Point(149, 316);
            this.seeBorrowedBooks.Name = "seeBorrowedBooks";
            this.seeBorrowedBooks.Size = new System.Drawing.Size(123, 51);
            this.seeBorrowedBooks.TabIndex = 3;
            this.seeBorrowedBooks.Text = "See borrowed books for selected client";
            this.seeBorrowedBooks.UseVisualStyleBackColor = true;
            this.seeBorrowedBooks.Click += new System.EventHandler(this.seeBorrowedBooks_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(149, 242);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(123, 51);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(433, 445);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.seeBorrowedBooks);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.bookComboBox);
            this.Name = "BorrowBookForm";
            this.Text = "BorrowBookForm";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private LibraryManagerDataSet libraryManagerDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryManagerDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button seeBorrowedBooks;
        private System.Windows.Forms.Button returnButton;
    }
}