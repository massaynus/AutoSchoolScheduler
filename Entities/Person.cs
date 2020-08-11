using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string CIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Adresse { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }

        public int TypeID { get; set; }
        public PersonType Type { get; set; }
    }
}