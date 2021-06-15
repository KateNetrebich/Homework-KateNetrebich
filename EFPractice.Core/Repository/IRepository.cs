using EFPractice.Core.Entities;
using EFPractice.Core.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFPractice.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> FindAsync(int id);
        Task <IEnumerable<TEntity>> GetAsync(Specification<TEntity> specification);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
