using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Branche
    {
        [Key]
        public int BrancheID { get; set; }
        public string BrancheName { get; set; }

        public IEnumerable<BrancheModule> Modules { get; set; }
    }
}