using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.Model
{
    public class BookstoreContextFactory : IDesignTimeDbContextFactory<BookstoreContext>
    {
        public BookstoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookstoreContext>();
            optionsBuilder.UseSqlite("Data Source=database.db");
            SQLitePCL.Batteries.Init();

            return new BookstoreContext(optionsBuilder.Options);
        }
    }
}
