using EFPractice.Core.Entities;
using System;
using System.Linq.Expressions;

namespace EFPractice.Core.Specification
{
    public class Specification<TEntity> where TEntity : Entity
    {
        public Specification(Expression<Func<TEntity, bool>> expression)
        {
            Expression = expression;
        }
        public Expression<Func<TEntity, bool>> Expression{ get; }
    }
}
