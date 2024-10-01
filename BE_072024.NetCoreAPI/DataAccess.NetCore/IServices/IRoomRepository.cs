using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.NetCore.DO;

namespace DataAccess.NetCore.IServices
{
    public interface IRoomRepository
    {
        //Task<IEnumerable<BE072024_HB_Rooms>> GetAllRooms();
        //Task<BE072024_HB_Rooms> GetRoomById(int id);
        //Task<IEnumerable<BE072024_HB_Rooms>> SearchRooms(string searchTerm);
        //Task AddRoom(BE072024_HB_Rooms room);
        //Task UpdateRoom(BE072024_HB_Rooms room);
        //Task DeleteRoom(int id);

        Task<List<BE072024_HB_Rooms>> Room_GetAll(HB_RoomGetAllRequestData requestData);
        Task<ReturnData> Room_Insert(Room_InsertRequestData requestData);
    }
}