using DAL.Model.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DAL.Repository.Implementations.Classes
{
    public class UserAccountImpl : BaseRepository<UserAccount, Guid>
    {
        public override void Delete(Guid id)
        {
            context.Database.OpenConnection();
            UserAccount tracking = context.Set<UserAccount>().Where(e => e.UserAccountID == id).Select(e => e).AsQueryable().FirstOrDefault();
            tracking.IsDeleted = notActive;
            Update(tracking);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override UserAccount GetByID(Guid id)
        {
            context.Database.OpenConnection();
            UserAccount tracking = context.Set<UserAccount>().Where(e => e.UserAccountID == id).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return tracking;
        }

        public UserAccount GetByUsername(string username)
        {
            context.Database.OpenConnection();
            UserAccount tracking = context.Set<UserAccount>().Where(e => e.Username == username).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return tracking;
        }
    }
}
