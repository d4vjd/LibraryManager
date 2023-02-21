using LibraryManager.DataModels;
using System.Data.Entity;

namespace LibraryManager.DataModels
{
    public class Context : DbContext
    {
        public Context() : base("name=Context") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }

    }
}
