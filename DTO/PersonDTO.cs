using System;
using API1_EX.Enum;

namespace API1_EX.DTO
{
    public class PersonDTO
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public DateTime DateOfBirth {get;set;}
        public Gender Gender {get;set;}
        public string BirthPlace {get;set;}
        public int Id { get; internal set; }
    }
}