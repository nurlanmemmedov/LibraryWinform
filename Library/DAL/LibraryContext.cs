using System.Data.Entity;
using Library.Models;

namespace Library.DAL
{
    class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {

        }
        //creating Tables in the database according to Models
        public DbSet<Book> Books { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
