using BE072024.DataAcceess_NetFrameWork.DO.Session10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session10
{
    public interface IRoomRepository 
    {
        IEnumerable<Room> GetAllRooms();
        ActionResult AddRoom(Room room);
        ActionResult DeleteRoom(int roomNumber);
        Room GetRoomById(int roomNumber);
    }
}
