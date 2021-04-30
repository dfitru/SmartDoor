using SmartDoor.Data;
using SmartDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDoor.Services
{
    public class DoorService
    {
        public bool CreateDoor(SmartDoorCreate model)
        {
            var entity =
                new Door()
            {
                DoorName=model.DoorName,
                FloorNumber=model.FloorNumber,
                IsRoomInRoom=model.IsRoomInRoom,
                BuildingId=model.BuildingId

            };
            using(var ctx=new ApplicationDbContext())
            {
                ctx.SmartDoors.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public DoorDetail GetDoorById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SmartDoors
                    .Single(e => e.DoorId == id);
                return
                    new DoorDetail
                    {
                        DoorId = entity.DoorId,
                        DoorName = entity.DoorName,
                        FloorNumber = entity.FloorNumber,
                        IsRoomInRoom = entity.IsRoomInRoom,
                        BuildingId = entity.BuildingId,
                        BuildingLis = new BuildingListItems() { BuildingId = entity.Building.BuildingId, BuildingName = entity.Building.BuildingName, Address = entity.Building.Address }
                    };

            }
        }
        public IEnumerable<SmartDoorItemList> GetDoors()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SmartDoors
                    .Select(
                        e =>
                        new SmartDoorItemList
                        {
                            DoorId = e.DoorId,
                            DoorName = e.DoorName,
                            FloorNumber = e.FloorNumber,
                            IsRoomInRoom = e.IsRoomInRoom,
                            BuildingId = e.BuildingId
                        });
                return query.ToArray();
            }
        }
        public IEnumerable<SmartDoorItemList> GetBuildingById(int id)
        {
           using(var ctx=new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SmartDoors
                    .Where(e => e.DoorId == id)
                    .Select(e =>
                    new SmartDoorItemList
                    {

                    }
                    );
                return query.ToArray();
                     
            };
        }
        //public bool UpdateSmartDoor(SmartDoorEdit model)
        //{
        //    using (var ctx=new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //            .SmartDoors
        //            .Single(e => e.DoorId == model.DoorId);
        //        entity.DoorName
        //    }
        }

    }
}
