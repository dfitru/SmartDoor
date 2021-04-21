using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoor.Data
{
   public class SmartDoor
    {
        [Key]
        public int DoorId { get; set; }
        [Required]
        public string DoorName { get; set; }
        [Required]
        public int FloorNumber { get; set; }
        [Required]
        public bool IsRoomInRoom { get; set; }
      
        [ForeignKey(nameof(Building))]
        public int? BuildingId { get; set; }
        public virtual Building Building { get; set; }
        public virtual ICollection<SmartKey> SmartKeys { get; set; }


    }
}
