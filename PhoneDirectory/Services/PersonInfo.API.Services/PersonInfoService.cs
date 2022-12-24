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

        public void Delete(string id)
        {
            _personRepository.Delete(id);
        }

        public IEnumerable<Person> GetAllPerson()
        {
            var personList = _personRepository.GetAll();

            return personList;
        }

        public void Insert(Person model)
        {
            model = new Person()
            {
                UUID = model.UUID,
                Name = model.Name,
                Surname = model.Surname,
                Company = model.Company,
                ContactInfoList = model.ContactInfoList
            };

            _personRepository.Insert(model);
        }

        public void Update(Person model, string id)
        {
            _personRepository.Update(model, id);
        }
    }
}
