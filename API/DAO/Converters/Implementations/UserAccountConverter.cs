using API.DAO.Classes;
using DAL.Model.Classes;
using System.Collections.Generic;

namespace API.DAO.Converters.Implementations
{
    public class UserAccountConverter : IConverter<UserAccount, UserAccountDAO>
    {
        public UserAccountConverter() { }
        public List<UserAccount> DaoListToEntityList(List<UserAccountDAO> daos)
        {
            List<UserAccount> entities = new List<UserAccount>();
            foreach (UserAccountDAO dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public UserAccount DaoToEntity(UserAccountDAO dao)
        {
            UserAccount entity = new UserAccount
            {
                UserAccountID = dao.UserAccountID,
                Username = dao.Username,
                Password = dao.Password,
                IsDeleted = dao.IsDeleted
            };
            return entity;
        }

        public List<UserAccountDAO> EntityListToDaoList(List<UserAccount> entities)
        {
            List<UserAccountDAO> daos = new List<UserAccountDAO>();
            foreach (UserAccount entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }

        public UserAccountDAO EntityToDao(UserAccount entity)
        {
            UserAccountDAO dao = new UserAccountDAO
            {
                UserAccountID = entity.UserAccountID,
                Username = entity.Username,
                Password = entity.Password,
                IsDeleted = entity.IsDeleted
            };
            return dao;
        }
    }
}
