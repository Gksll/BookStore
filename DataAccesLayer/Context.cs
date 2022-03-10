using BookStore.Models;
using Entities.Concrete;
using System.Data.Entity;

namespace DataAccesLayer
{
    public class Context : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Volume> Volumes { get; set; }
        public virtual DbSet<AdminType> AdminTypes { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }


    }
}
