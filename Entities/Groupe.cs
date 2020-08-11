using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Groupe
    {
        [Key]
        public int GroupeID { get; set; }
        public string GroupeName { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}