using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class BrancheModule
    {
        [Key]
        public int ID { get; set; }
        public Module Module { get; set; }
        public int ModuleID { get; set; }
        public Branche Branche { get; set; }
        public int BrancheID { get; set; }
    }
}