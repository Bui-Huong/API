using System;
using Microsoft.EntityFrameworkCore;
using API1_EX.Entities;
using API1_EX.Enum;

namespace API1_EX.DB
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}