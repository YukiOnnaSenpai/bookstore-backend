using DAL.Model.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DAL.Repository.Implementations.Classes
{
    public class BookImpl : BaseRepository<Book, Guid>
    {
        public override void Delete(Guid id)
        {
            context.Database.OpenConnection();
            Book tracking = context.Set<Book>().Where(e => e.BookID == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsDeleted = notActive;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Book GetByID(Guid id)
        {
            context.Database.OpenConnection();
            Book tracking = context.Set<Book>().Where(e => e.BookID == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return tracking;
        }
    }
}
