using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Module
    {
        [Key]
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public int Length { get; set; }

        public IEnumerable<BrancheModule> Branches { get; set; }
        public IEnumerable<TeacherModule> ModuleTeachers { get; set; }
    }
}