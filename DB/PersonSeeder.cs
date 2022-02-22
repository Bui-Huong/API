using System;
using System.Collections.Generic;
using API1_EX.Entities;
using API1_EX.Enum;

namespace API1_EX.DB
{
    public class PersonSeeder
    {
        private readonly PersonContext _context;
        public PersonSeeder(PersonContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            _context.People.AddRange(new List<Person>
            {
                new Person { Id = 1, FirstName = "Bui", LastName = "Chi Huong", DateOfBirth = new DateTime(2000, 6, 26), Gender = Gender.Male, BirthPlace = "Bac Ninh" },
                new Person { Id = 2, FirstName = "Nguyen", LastName = "Thanh Loc", DateOfBirth = new DateTime(1999, 6, 26), Gender = Gender.Female, BirthPlace = "ha Noi" },
                new Person { Id = 3, FirstName = "Hoang", LastName = "Duc Anh", DateOfBirth = new DateTime(2001, 6, 26), Gender = Gender.Other, BirthPlace = "Cao Bang" }
            });

            _context.SaveChanges();
        }
    }
}