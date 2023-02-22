using LibraryManager.DataModels;
using System;
using LibraryManager.DataModels;
using LibraryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context = LibraryManager.DataModels.Context;
using System.Data.Entity.Validation;

namespace LibraryManager
{
    public partial class BorrowBookForm : Form
    {
        private Context context;
        public BorrowBookForm(Context context)
        {
            InitializeComponent();
            this.context = context;

            bookComboBox.DataSource = context.Books.ToList();
            bookComboBox.DisplayMember = "Title";

            clientComboBox.DataSource = context.Clients.ToList();
            clientComboBox.DisplayMember = "Name";
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagerDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryManagerDataSet.Books);

        }

        public void borrowButton_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)bookComboBox.SelectedItem;
            var selectedClient = (Client)clientComboBox.SelectedItem;

            if (selectedBook == null || selectedClient == null)
            {
                MessageBox.Show("Please select a book and a client.");
                return;
            }

            selectedClient.BorrowedBooks.Add(selectedBook);

            try
            {
                context.SaveChanges();
                MessageBox.Show("Book borrowed successfully.");
                this.Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("An error occurred while saving changes to the database:\n\n" + ex.Message);
            }
        }


        private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seeBorrowedBooks_Click(object sender, EventArgs e)
        {
            var selectedClient = (Client)clientComboBox.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client.");
                return;
            }

            var borrowedBooks = selectedClient.BorrowedBooks.ToList();

            if (borrowedBooks.Count == 0)
            {
                MessageBox.Show("This client has no borrowed books.");
            }
            else
            {
                var borrowedBooksList = string.Join("\n", borrowedBooks.Select(bb => bb.Title));
                MessageBox.Show($"Borrowed Books:\n{borrowedBooksList}");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)bookComboBox.SelectedItem;
            var selectedClient = (Client)clientComboBox.SelectedItem;

            if (selectedBook == null || selectedClient == null)
            {
                MessageBox.Show("Please select a book and a client.");
                return;
            }

            selectedClient.BorrowedBooks.Remove(selectedBook);

            try
            {
                context.SaveChanges();
                MessageBox.Show("Book returned successfully.");
                this.Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("An error occurred while saving changes to the database:\n\n" + ex.Message);
            }
        }

    }
}
