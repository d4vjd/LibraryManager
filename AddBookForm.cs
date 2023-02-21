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
    public partial class AddBookForm : Form
    {
        public LibraryManager.Logic.Logic logic = new LibraryManager.Logic.Logic();
        private Context context;
        private MainForm mainForm;

        public AddBookForm(Context context, MainForm mainForm)
        {
            InitializeComponent();
            this.context = context;
            this.mainForm = mainForm;

            BookAdded += mainForm.OnBookAdded;
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = titleTextBox.Text;
            book.Author = authorTextBox.Text;
            book.ISBN = isbnTextBox.Text;
            book.PublicationDate = publicationDateTimePicker.Value;
            book.Publisher = publisherTextBox.Text;
            book.Genre = genreTextBox.Text;
            book.Summary = summaryTextBox.Text;
            book.CoverImage = coverImageTextBox.Text;
            book.Rating = Convert.ToDouble(ratingNumericUpDown.Value);

            context.Books.Add(book);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //this code loops through the EntityValidationErrors collection and builds a
                //string that lists each property and its corresponding validation error.
                StringBuilder sb = new StringBuilder();

                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }

                MessageBox.Show($"An error occurred while adding the client:\n\n{sb.ToString()}");
                return;
            }

            OnBookAdded(EventArgs.Empty);

            this.Close();

        }

        public event EventHandler BookAdded;
        public virtual void OnBookAdded(EventArgs e)
        {
            BookAdded?.Invoke(this, e);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        public void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void isbnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void publisherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void genreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void summaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
