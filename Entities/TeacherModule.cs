using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class TeacherModule
    {
        [Key]
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public int ModuleID { get; set; }
        public Module Module { get; set; }
    }
}