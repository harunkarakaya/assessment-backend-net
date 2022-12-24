using DataAccess.Abstract;
using DataAccess.ConcreteRepo;
using DataAccess.Context;
using MongoDB.Bson;
using MongoDB.Driver;
using PersonInfo.API.Entities;
using PersonInfo.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.Services
{
    public class PersonInfoService : IPersonInfoService
    {
        private readonly IPersonRepository _personRepository;

        public PersonInfoService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> GetAllPerson()
        {
            var personList = _personRepository.GetAll();

            return personList;
        }

    }
}
