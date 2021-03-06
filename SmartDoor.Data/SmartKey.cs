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
        public int KeyId { get; set; }
        [Required]
        public Guid OwnerID { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
        [Required]
        public bool KeyRecived { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}")]
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(KeyOwner))]
        public int? KeyOwnerId { get; set; }
        public virtual KeyOwner KeyOwner { get; set; }
        [ForeignKey(nameof(SmartDoor))]
        public int? DoorId { get; set; }
        public virtual Door SmartDoor { get; set; }
    }
}
