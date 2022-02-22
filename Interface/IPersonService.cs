using System.Collections.Generic;
using API1_EX.DTO;
using API1_EX.Entities;

namespace RK_A8.Interface
{
    public interface IPersonService
    {
        void AddPerson(PersonDTO person);
        void DeletePerson(int id);
        void UpdatePerson(PersonDTO person);
        List<Person> Filter(FilterPersonDTO person);
    }
}