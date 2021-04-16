using API.DAO.Classes;
using API.DAO.Converters;
using DAL.Model.Classes;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace API.Service.Implementations
{
    public class UserAccountService : IService<UserAccountDAO>
    {
        private readonly IRepository<UserAccount, Guid> _repository;
        private readonly IConverter<UserAccount, UserAccountDAO> _converter;

        public UserAccountService(IRepository<UserAccount, Guid> repository, IConverter<UserAccount, UserAccountDAO> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(UserAccountDAO dao)
        {
            UserAccount entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public List<UserAccountDAO> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public UserAccountDAO GetById(Guid id)
        {
            return _converter.EntityToDao(_repository.GetByID(id));
        }

        public void Update(UserAccountDAO dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }

        public bool IsUsernameUnique(string username) 
        {
            //not the best solution at all
            List<UserAccount> accounts = _repository.GetAll();
            foreach (UserAccount acc in accounts)
            {
                if (acc.Username == username)
                    return true;
            }
            return false;
        }
    }
}
