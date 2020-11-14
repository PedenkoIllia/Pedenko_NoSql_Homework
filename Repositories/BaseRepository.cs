using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using VeterinaryClinic.Entities.Interfaces;

namespace VeterinaryClinic.Repositories
{
    class BaseRepository<TEntity> where TEntity : IEntity
    {
        protected readonly IMongoCollection<TEntity> collection;

        public BaseRepository(IMongoDatabase database)
        {
            collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public IEnumerable<TEntity> Get() =>
            collection.Find(entity => true).ToList();

        public TEntity Get(ObjectId id)
        {
            var filter = Builders<TEntity>.Filter.Eq(e => e.Id, id);
            return collection.Find(filter).FirstOrDefault();
        }

        public TEntity Insert(TEntity entity)
        {
            collection.InsertOne(entity);
            return entity;
        }

        public void InsertRange(IEnumerable<TEntity> entity)
        {
            collection.InsertMany(entity);
        }

        public void Update(TEntity entity)
        {
            var filter = Builders<TEntity>.Filter.Eq(e => e.Id, entity.Id);
            collection.ReplaceOne(filter, entity);
        }

        public void Delete(TEntity entity) =>
            collection.DeleteOne(e => e.Id == entity.Id);
    }
}
