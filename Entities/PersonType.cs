using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Scheduler
{
    public class PersonType
    {
        [Key]
        public int PTID { get; set; }
        public string Name { get; set; }

        public IEnumerable<Person> People { get; set; }
    }
}