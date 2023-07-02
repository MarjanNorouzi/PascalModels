using Microsoft.AspNetCore.Mvc;
using PersonalInformation.Models;
using PersonalInformation.Services;
using PersonalInformation.Validation;
using PersonalInformation.Validations;
using System.Globalization;

namespace PersonalInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonService service;
        public PersonsController(PersonService service)
        {
            this.service = service;
        }

        [HttpGet]
        public Person? GetPerson()
        {
            return service.Get();
        }

        [HttpPost]
        public bool Create([FromBody] Person person)
        {
            PersonValidator validator = new PersonValidator();
            var result = validator.Validate(person);

            if (result.IsValid)
            {
                service.Create(person);
                return true;
            }

            else
                return false;
        }

    }
}
