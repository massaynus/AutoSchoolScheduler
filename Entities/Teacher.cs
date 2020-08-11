using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Scheduler
{
    public class Teacher : Person
    {
        public string RIB { get; set; }
        public IEnumerable<TeacherModule> ModuleTeachers { get; set; }

    }
}