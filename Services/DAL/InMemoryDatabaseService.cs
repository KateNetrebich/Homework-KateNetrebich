using System.Collections.Generic;
using System.Linq;
using DI.App.Abstractions;

namespace DI.App.Services
{
    public class InMemoryDatabaseService<T> : IDatabaseService<T> where T : IDbEntity 
    {
        private readonly Dictionary<int, T> inMemoryDatabase = new Dictionary<int, T>();

        public IEnumerable<T> Read() 
        {
            return this.inMemoryDatabase.Values;
        }

        public void Write(params T[] data)
        {
            foreach (var entity in data)
            {
                this.inMemoryDatabase.TryAdd(entity.Id, entity);
            }
        }
    }
}