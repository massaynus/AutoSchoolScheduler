using System.ComponentModel.DataAnnotations;

namespace Scheduler
{
    public class ClassRoomEquipement
    {
        [Key]
        public int ID { get; set; }
        public ClassRoom Room { get; set; }
        public int RoomID { get; set; }
        public Equipement Equipement { get; set; }
        public int EquipementID { get; set; }
        public int UsedCount { get; set; }
    }
}