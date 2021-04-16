using System.Collections.Generic;

namespace DAL.Repository.Interfaces
{
    public interface IRepository<TEntity, K> where TEntity: class
    {
        void Add(TEntity entity);
        List<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(K id);
        TEntity GetByID(K id);
    }
}
