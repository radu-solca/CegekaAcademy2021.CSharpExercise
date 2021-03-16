using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GenericsExercise
{
    public class Persistence
    {
        private readonly IDictionary<string, ICollection<string>> storage;

        public Persistence()
        {
            storage = new Dictionary<string, ICollection<string>>();
        }

        public Task InsertAsync<TEntity>(TEntity entity) where TEntity : IEntity
        {
            if (
                string.IsNullOrWhiteSpace(entity.Id) || // Id cannot be empty
                entity.Id.Contains("%") || // Id cannot contain %
                entity.Id.Length > 10 // Id cannot be longer than 10 characters
            )
            {
                throw new ArgumentException("Id is invalid");
            }

            if (!storage.ContainsKey(typeof(TEntity).FullName))
            {
                storage[typeof(TEntity).FullName] = new List<string>();
            }

            if (storage[typeof(TEntity).FullName].Count >= 3) // there cannot be more than 3 items of a type
            {
                throw new InvalidOperationException("Cannot insert more than 3 entities of the same type");
            }

            storage[typeof(TEntity).FullName].Add(JsonSerializer.Serialize(entity));

            return Task.Run(() => { });
        }

        public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : IEntity
        {
            if (!storage.ContainsKey(typeof(TEntity).FullName))
            {
                throw new InvalidOperationException("No entities of this type stored");
            }

            return Task.Run(() => storage[typeof(TEntity).FullName].Select(json => JsonSerializer.Deserialize<TEntity>(json)));
        }
    }
}
