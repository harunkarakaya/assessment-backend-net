using PersonInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.Infrastructure
{
    public interface IPersonInfoService
    {
        IEnumerable<Person> GetAllPerson();

        void Insert(Person model);

        void Update(Person model,string id);

        void Delete(string id);
    }
}
