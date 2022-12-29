using PersonInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo.API.DataAccess.Abstract
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
