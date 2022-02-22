using System.Collections.Generic;
using API1_EX.DTO;
using API1_EX.Entities;
using Microsoft.AspNetCore.Mvc;
using RK_A8.Interface;

namespace API1_EX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpPost("/add-person")]
        public void AddPerson([FromBody] PersonDTO person)
        {
            _service.AddPerson(person);
        }
        [HttpDelete("/delete-person")]
        public void DeletePerson(int id)
        {
            _service.DeletePerson(id);
        }
        [HttpPut("/update-person")]
        public void UpdatePerson([FromBody] PersonDTO person){
            _service.UpdatePerson(person);
        }
        [HttpPost("/filter-person")]
        public List<Person> Filter([FromBody] FilterPersonDTO filter){
            return _service.Filter(filter);
        }
    }
}