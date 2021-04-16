using DAL.Model.Classes;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions options) : base(options) { }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // in Package Manager Console run "add-migration init" and then run "update-database"
            optionsBuilder.UseSqlite("Data Source=database.db");
            SQLitePCL.Batteries.Init();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("book");
            modelBuilder.Entity<UserAccount>().ToTable("user_account");
        }
    }
}
