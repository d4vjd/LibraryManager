using LibraryManager.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Logic
{
    public class Logic
    {
        private Context context = new Context();
        public void AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books.AsEnumerable();
        }

        public IEnumerable<Book> SearchByTitle(string title)
        {
            return context.Books.Where(b => b.Title.Contains(title)).AsEnumerable();
        }

        public IEnumerable<Book> SearchByAuthor(string author)
        {
            return context.Books.Where(b => b.Author.Contains(author)).AsEnumerable();
        }

        public Book SearchByISBN(string isbn)
        {
            return context.Books.FirstOrDefault(b => b.ISBN == isbn);
        }

    }
}
