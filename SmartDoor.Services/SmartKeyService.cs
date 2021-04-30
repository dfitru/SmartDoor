using SmartDoor.Data;
using SmartDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoor.Services
{
    public class SmartKeyService
    {
        private readonly Guid _userId;
        public SmartKeyService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateSmartkey(SmartKeyCreate model)
        {
            var entity =
                new SmartKey()
                {
                    OwnerID = _userId,
                    Name = model.Name,
                    KeyRecived = model.KeyRecived,


                };
            using (var ctx =new ApplicationDbContext())
            {
                ctx.SmartKeys.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        
        public bool UpdateSmartDoo(SmartDoorEdit model)
        {
            using(var ctx=new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SmartDoors
                    .Single(e => e.DoorId == model.DoorId);
                entity.DoorName = model.DoorName;
                entity.FloorNumber = model.FloorNumber;
                entity.IsRoomInRoom = model.IsRoomInRoom;
                entity.BuildingId = model.BuildingId;
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
