using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class Equipement
    {
        [Key]
        public int EquipementID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }

        public IEnumerable<ClassRoomEquipement> ClassRooms { get; set; }
    }
}