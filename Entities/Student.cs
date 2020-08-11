using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Student : Person
    {
        public string ParentGSM { get; set; }
        public string Matricule { get; set; }

        public Groupe Groupe { get; set; }
        public int GroupeID { get; set; }
    }
}