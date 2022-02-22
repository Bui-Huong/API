using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API1_EX.Enum;

namespace API1_EX.Entities
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public DateTime DateOfBirth {get;set;}
        public Gender Gender {get;set;}
        public string BirthPlace {get;set;}

        internal static object FirstOrDefault(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}