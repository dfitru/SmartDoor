using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoor.Data
{
    public class SmartKey
    {
        [Key]
        public int DoorId { get; set; }
        [Required]
        public string DoorName { get; set; }
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public bool KeyRecived { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [ForeignKey(nameof(Building))]
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }
        [ForeignKey(nameof(KeyOwner))]
        public int OwnerId { get; set; }
        public virtual KeyOwner KeyOwner { get; set; }
        [ForeignKey(nameof(SmartDoor))]
        public int RoomId { get; set; }
        public virtual SmartDoor SmartDoor { get; set; }
    }
}
