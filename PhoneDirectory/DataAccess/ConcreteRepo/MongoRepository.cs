using PersonInfo.API.DataAccess.Abstract;
using PersonInfo.API.DataAccess.Context;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PersonInfo.API.DataAccess.ConcreteRepo
{
    public class MongoRepository<TEntity> : IRepository<TEntity> where TEntity : class, new() 
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<TEntity> _collection;
        public MongoRepository(IOptions<MongoSettings> settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<TEntity>();
        }
        public void Delete(string id)
        {
            var objectId = ObjectId.Parse(id);
            var filter = Builders<TEntity>.Filter.Eq("_id", objectId);
            _collection.FindOneAndDelete(filter);
        }

        public TEntity GetById(string id)
        {
            var objectId = ObjectId.Parse(id);
            var filter = Builders<TEntity>.Filter.Eq("_id", objectId);
            var data = _collection.Find(filter).FirstOrDefault();

            return data;
        }

        public void Insert(TEntity model)
        {
            _collection.InsertOne(model);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _collection.AsQueryable().ToList();
        }

        public IEnumerable<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter)
        {
            return _collection.Find(filter).ToList();
        }

        public void Update(TEntity model, string id)
        {
            var objectId = ObjectId.Parse(id);
            var filter = Builders<TEntity>.Filter.Eq("_id", objectId);
            var data = _collection.ReplaceOne(filter, model);
        }
    }
}
