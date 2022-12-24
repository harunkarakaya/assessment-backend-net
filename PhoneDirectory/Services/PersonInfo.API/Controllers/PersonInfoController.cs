using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonInfo.API.Entities;
using PersonInfo.API.Infrastructure;
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
        public Person GetPerson(int Id)
        {
            return _personInfoService.GetPersonByID(Id);
        }
    }
}
