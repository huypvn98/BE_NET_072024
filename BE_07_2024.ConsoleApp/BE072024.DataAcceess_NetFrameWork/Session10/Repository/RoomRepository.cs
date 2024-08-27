using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session10.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly List<Room> _rooms;
        public RoomRepository(List<Room> rooms)
        {
            _rooms = rooms;
        }

        public ActionResult AddRoom(Room room)
        {
            try
            {
                //Kiểm tra xem phòng đã tồn tại chưa
                if (_rooms.Any(r => r.RoomNumber == room.RoomNumber))
                {
                    return new ActionResult { IsSuccess = false, Message = $"Phòng {room.RoomNumber} đã tồn tại." };
                }
                _rooms.Add(room);
                return new ActionResult { IsSuccess = true, Message = $"Phòng {room.RoomNumber} đã được tạo." };  
            }
            catch (Exception ex)
            {
                return new ActionResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public ActionResult DeleteRoom(int roomNumber)
        {
            try
            {
                var room = _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
                if (room != null)
                {
                    _rooms.Remove(room);
                    return new ActionResult { IsSuccess = true, Message = $"Phòng số {roomNumber} đã được xóa." };
                }
                else
                {
                    return new ActionResult { IsSuccess = false, Message = $"Không tìm thấy phòng số {roomNumber}." };
                }
            }
            catch (Exception ex)
            {
                return new ActionResult { IsSuccess = false, Message = ex.Message };
            }
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _rooms;
        }

        public Room GetRoomById(int roomNumber)
        {
            return _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
}
