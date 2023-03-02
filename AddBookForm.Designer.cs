namespace LibraryManager
{
    partial class AddBookForm
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
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.publicationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.coverImageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.Location = new System.Drawing.Point(122, 365);
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(193, 20);
            this.ratingNumericUpDown.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Rating:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(159, 440);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 62);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // publicationDateTimePicker
            // 
            this.publicationDateTimePicker.Location = new System.Drawing.Point(122, 339);
            this.publicationDateTimePicker.Name = "publicationDateTimePicker";
            this.publicationDateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.publicationDateTimePicker.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Publication Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cover Image:";
            // 
            // coverImageTextBox
            // 
            this.coverImageTextBox.Location = new System.Drawing.Point(110, 296);
            this.coverImageTextBox.Name = "coverImageTextBox";
            this.coverImageTextBox.Size = new System.Drawing.Size(296, 20);
            this.coverImageTextBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Summary:";
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(110, 158);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(296, 113);
            this.summaryTextBox.TabIndex = 30;
            this.summaryTextBox.TextChanged += new System.EventHandler(this.summaryTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(110, 116);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(296, 20);
            this.genreTextBox.TabIndex = 28;
            this.genreTextBox.TextChanged += new System.EventHandler(this.genreTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Publisher:";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(110, 64);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(296, 20);
            this.isbnTextBox.TabIndex = 26;
            this.isbnTextBox.TextChanged += new System.EventHandler(this.isbnTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "ISBN:";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(110, 90);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(296, 20);
            this.publisherTextBox.TabIndex = 24;
            this.publisherTextBox.TextChanged += new System.EventHandler(this.publisherTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Author:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(110, 38);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(296, 20);
            this.authorTextBox.TabIndex = 22;
            this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(110, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(296, 20);
            this.titleTextBox.TabIndex = 20;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(129)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(487, 536);
            this.Controls.Add(this.ratingNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.publicationDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.coverImageTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker publicationDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coverImageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}