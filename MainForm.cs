using LibraryManager.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        private LibraryManager.Logic.Logic logic = new LibraryManager.Logic.Logic();
        private Context context = new Context();

        public MainForm()
        {
            InitializeComponent();

            BookList.DataSource = context.Books.ToList();
            BookList.DisplayMember = "Title";

            ClientList.DataSource = context.Clients.ToList();
            ClientList.DisplayMember = "Name";

            AddBookForm addBookForm = new AddBookForm(context, this);

        }

        // add/delete books

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(context, this);
            addBookForm.ShowDialog();
        }

        public void OnBookAdded(object sender, EventArgs e)
        {
            BookList.DataSource = null;
            BookList.DataSource = context.Books.ToList();
            BookList.DisplayMember = "Title";
        }
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            Book selectedBook = BookList.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show("Please select a book to delete.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Books.Remove(selectedBook);
                    context.SaveChanges();
                    BookList.DataSource = null;
                    BookList.DataSource = context.Books.ToList();
                    BookList.DisplayMember = "Title";
                }
            }
        }

        // add/delete clients

        private void addClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(context, this);
            addClientForm.ShowDialog();
        }

        public void OnClientAdded(object sender, EventArgs e)
        {
            ClientList.DataSource = null;
            ClientList.DataSource = context.Clients.ToList();
            ClientList.DisplayMember = "Name";
        }
        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            Client selectedClient = ClientList.SelectedItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client to delete.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Clients.Remove(selectedClient);
                    context.SaveChanges();
                    ClientList.DataSource = null;
                    ClientList.DataSource = context.Clients.ToList();
                    ClientList.DisplayMember = "Name";
                }
            }
        }

        //borrow book

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            var borrowBookForm = new BorrowBookForm(context);
            borrowBookForm.ShowDialog();
        }




        private void InitializeComponent()
        {
            this.BookList = new System.Windows.Forms.ListBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(12, 38);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(251, 355);
            this.BookList.TabIndex = 0;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Location = new System.Drawing.Point(556, 38);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(251, 355);
            this.ClientList.TabIndex = 1;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(340, 70);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(133, 46);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(340, 122);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(133, 48);
            this.deleteBookButton.TabIndex = 3;
            this.deleteBookButton.Text = "Delete book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client List:";
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(340, 176);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(133, 46);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Add client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(340, 228);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(133, 46);
            this.deleteClientButton.TabIndex = 7;
            this.deleteClientButton.Text = "Delete client";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.Location = new System.Drawing.Point(340, 280);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(133, 58);
            this.borrowBookButton.TabIndex = 8;
            this.borrowBookButton.Text = "Borrow book / See borrowed books / Return book";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(819, 441);
            this.Controls.Add(this.borrowBookButton);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.BookList);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
