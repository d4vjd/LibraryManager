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

            var books = new List<Book>
            {
        //     new Book
        //{
        //    ISBN = "9780590353403",
        //    Title = "Harry Potter and the Philosopher's Stone",
        //    Author = "J.K. Rowling",
        //    PublicationDate = new DateTime(1997, 6, 26),
        //    Publisher = "Bloomsbury Publishing",
        //    Genre = "Fantasy",
        //    Summary = "Harry Potter has never played a sport while flying on a broomstick. He's never worn a cloak of invisibility, befriended a giant, or helped hatch a dragon. All Harry knows is a miserable life with the Dursleys, his horrible aunt and uncle, and their abominable son, Dudley. Harry's room is a tiny cupboard under the stairs, and he hasn't had a birthday party in ten years.",
        //    CoverImage = "harry_potter_philosophers_stone.jpg",
        //    Rating = 4.5
        //},
        //     new Book
        //{
        //    ISBN = "9780439554930",
        //    Title = "Harry Potter and the Chamber of Secrets",
        //    Author = "J.K. Rowling",
        //    PublicationDate = new DateTime(1998, 7, 2),
        //    Publisher = "Bloomsbury Publishing",
        //    Genre = "Fantasy",
        //    Summary = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School of Witchcraft and Wizardry. But just as he's packing his bags, Harry receives a warning from a strange, impish creature named Dobby who says that if Harry Potter returns to Hogwarts, disaster will strike.",
        //    CoverImage = "harry_potter_chamber_of_secrets.jpg",
        //    Rating = 4.4
        //},
        //     new Book
        //{
        //    ISBN = "9780439554909",
        //    Title = "Harry Potter and the Prisoner of Azkaban",
        //    Author = "J.K. Rowling",
        //    PublicationDate = new DateTime(1999, 9, 8),
        //    Publisher = "Bloomsbury Publishing",
        //    Genre = "Fantasy",
        //    Summary = "Harry Potter is lucky to reach the age of thirteen, since he has survived the murderous attacks of the feared Dark Lord on more than one occasion. But his hopes for a quiet term concentrating on Quidditch are dashed when a maniacal mass-murderer escapes from Azkaban, pursued by the soul-sucking Dementors who guard the prison.",
        //    CoverImage = "harry_potter_prisoner_of_azkaban.jpg",
        //    Rating = 4.5
        //}
            };

            foreach (var book in books) //var was used here to add the first books into the db for testing
            {
                context.Books.Add(book);
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var error in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Validation error(s) for entity {0}", error.Entry.Entity.GetType().Name);
                    foreach (var errorMsg in error.ValidationErrors)
                    {
                        Console.WriteLine("- {0}: {1}", errorMsg.PropertyName, errorMsg.ErrorMessage);
                    }
                }
            }


            BookList.DataSource = context.Books.ToList();
            BookList.DisplayMember = "Title";
        }

        private void InitializeComponent()
        {
            this.BookList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(12, 12);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(182, 381);
            this.BookList.TabIndex = 0;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(601, 521);
            this.Controls.Add(this.BookList);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
