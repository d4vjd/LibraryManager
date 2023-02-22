using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.DataModels
{
    public class ClientData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual ICollection<Book> BorrowedBooks { get; set; }
    }
}

