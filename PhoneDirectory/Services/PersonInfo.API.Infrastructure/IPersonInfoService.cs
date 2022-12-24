using PersonInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.Infrastructure
{
    public interface IPersonInfoService
    {
        IEnumerable<Person> GetAllPerson();
    }
}
