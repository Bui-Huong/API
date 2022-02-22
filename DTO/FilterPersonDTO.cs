using API1_EX.Enum;

namespace API1_EX.DTO
{
    public class FilterPersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
    }
}