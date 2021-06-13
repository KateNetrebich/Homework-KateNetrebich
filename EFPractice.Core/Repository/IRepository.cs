using System.Collections.Generic;

namespace EFPractice.Core.Repository
{
    public interface IRepository<TEntity, TKey>
    {
        void Create(TEntity entity, TKey key);
        void Delete(TKey key);
        TEntity Get(TKey key);
        List<TEntity> List();
        void Update(TKey key, TEntity entity);
    }
}
