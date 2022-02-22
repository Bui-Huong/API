using API1_EX.DB;
using API1_EX.DTO;
using RK_A8.Interface;
using API1_EX.Entities;
using System.Linq;
using System.Collections.Generic;

namespace API1_EX.Services
{
    public class PersonService : IPersonService
    {
        private PersonContext _context;

        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public void AddPerson(PersonDTO person)
        {
            _context.People.Add(new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateOfBirth = person.DateOfBirth,
                Gender = person.Gender,
                BirthPlace = person.BirthPlace
            });

            _context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var human = _context.People.FirstOrDefault(m => m.Id == id);
            if (human != null)
            {
                _context.People.Remove(human);
                _context.SaveChanges();
            }
        }

        public List<Person> Filter(FilterPersonDTO person)
        {
            return _context.People.Where(m => (!string.IsNullOrEmpty(person.FirstName) && m.FirstName.ToLower() == person.FirstName.ToLower())
            || (!string.IsNullOrEmpty(person.LastName) && m.LastName.ToLower() == person.LastName.ToLower())
            || m.Gender == person.Gender
            || m.BirthPlace == person.BirthPlace).ToList();
        }

        public void UpdatePerson(PersonDTO person)
        {
            var human = _context.People.FirstOrDefault(m => m.Id == person.Id);
            if (human != null)
            {
                human.FirstName = person.FirstName;
                human.LastName = person.LastName;
                human.Gender = person.Gender;
                human.DateOfBirth = person.DateOfBirth;
                human.BirthPlace = person.BirthPlace;
                _context.SaveChanges();
            }
        }
    }
}