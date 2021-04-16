using System;
using System.Collections.Generic;

namespace API.Service
{
    public interface IService<TEntity>
    {
        public List<TEntity> GetAll();
        public TEntity GetById(Guid id);
        public void Add(TEntity dao);
        public void Update(TEntity dao);
        public void Delete(Guid id);
    }
}
