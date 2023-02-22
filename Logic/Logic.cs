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

        //book methods
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

        //client methods

        public void AddClient(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            context.Clients.Remove(client);
            context.SaveChanges();
        }

        public IEnumerable<Client> GetAllClients()
        {
            return context.Clients.AsEnumerable();
        }

        public IEnumerable<Client> SearchByName(string name)
        {
            return context.Clients.Where(c => c.Name.Contains(name)).AsEnumerable();
        }

        public Client SearchById(int id)
        {
            return context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public void BorrowBook(Client client, Book book)
        {
            client.BorrowedBooks.Add(book);
            context.SaveChanges();
        }

        public void ReturnBook(Client client, Book book)
        {
            client.BorrowedBooks.Remove(book);
            context.SaveChanges();
        }

        public IEnumerable<Book> GetBorrowedBooks(Client client)
        {
            return client.BorrowedBooks.AsEnumerable();
        }
    }
}
