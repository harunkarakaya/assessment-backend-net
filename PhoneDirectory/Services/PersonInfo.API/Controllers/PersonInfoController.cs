using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonInfo.API.Entities;
using PersonInfo.API.Infrastructure;
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

        [HttpGet("{Id}")]
        public IEnumerable<Person> GetPerson(string Id)
        {
            var data = _personInfoService.GetAllPerson();

            return data;
        }


    }
}
