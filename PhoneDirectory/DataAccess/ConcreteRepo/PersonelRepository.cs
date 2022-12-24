using DataAccess.Abstract;
using DataAccess.Context;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PersonInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ConcreteRepo
{
    public class PersonelRepository : MongoRepository<Person>, IPersonRepository
    {
        private readonly MongoDbContext _context;
        private readonly IMongoCollection<Person> _collection;
        public PersonelRepository(IOptions<MongoSettings> settings) : base(settings)
        {
            _context = new MongoDbContext(settings);
            _collection = _context.GetCollection<Person>();
        }
    }
}
