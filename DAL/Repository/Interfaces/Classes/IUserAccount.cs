using DAL.Model.Classes;
using System;

namespace DAL.Repository.Interfaces.Classes
{
    public interface IUserAccount : IRepository<UserAccount, Guid>
    {
    }
}
