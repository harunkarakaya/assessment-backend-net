using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using PersonInfo.API.Entities;
using PersonInfo.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonInfoController : ControllerBase
    {
        private readonly IPersonInfoService _personInfoService;
        public PersonInfoController(IPersonInfoService PersonInfoService)
        {
            _personInfoService = PersonInfoService;
        }

        //[HttpGet("{Id}")]
        [Route("GetAllPersonel")]
        [HttpGet]
        public IEnumerable<Person> GetPerson()
        {
            var data = _personInfoService.GetAllPerson();

            return data;
        }

        [Route("PersonelCreate")]
        [HttpGet]
        public string CreatePerson()
        {
            Person person = new Person()
            {
                UUID = ObjectId.GenerateNewId(),
                Name = "test",
                Surname = "testsurname",
                Company = "testcompany",
                ContactInfoList = new List<ContactInfo>() { new ContactInfo
                {
                    EmailAddress="test@gmail.com",
                    Location="testLocation2",
                    PhoneNumber = "0555 333 22 11",
                    InformationContent = "Bilgi içeriği"

                } }
            };

            _personInfoService.Insert(person);

            return "Kişi oluşturuldu.";
        }


        [Route("PersonelDelete/{id}")]
        [HttpGet("{Id}")]
        public void DeletePerson(string id)
        {
            _personInfoService.Delete(id);
        }
    }
}
