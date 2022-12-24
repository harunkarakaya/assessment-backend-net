using PersonInfo.API.Entities;
using PersonInfo.API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.Services
{
    public class PersonInfoService : IPersonInfoService
    {
        public Person GetPersonByID(int id)
        {
            return new Person()
            {
                UUID = id,
                Name = "Harun",
                Surname = "Karakaya",
                Company = "Sgs"   
            };
        }
    }
}
