using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class ClassRoom
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public IEnumerable<ClassRoomEquipement> Equipements { get; set; }
    }
}