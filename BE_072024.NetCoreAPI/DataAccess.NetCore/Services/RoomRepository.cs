using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.NetCore.DBContext;
using DataAccess.NetCore.DO;
using DataAccess.NetCore.IServices;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.NetCore.Services
{
    public class RoomRepository : IRoomRepository
    {
        private readonly BE_072024dDbContext _context;
    
        public RoomRepository(BE_072024dDbContext context)
        {
            _context = context;
        }

        //public async Task<IEnumerable<BE072024_HB_Rooms>> GetAllRooms()
        //{
        //    return await _context.bE072024_HB_Rooms.Include(r => r.Hotel).ToListAsync();
        //}

        //public async Task<BE072024_HB_Rooms> GetRoomById(int id)
        //{
        //    return await _context.bE072024_HB_Rooms.Include(r => r.Hotel).FirstOrDefaultAsync(r =>  r.RoomID == id);
        //}

        //public async Task<IEnumerable<BE072024_HB_Rooms>> SearchRooms(string searchTerm)
        //{
        //    return await _context.bE072024_HB_Rooms
        //        .Include(r => r.Hotel)
        //        .Where(r => r.RoomNumber.Contains(searchTerm) 
        //        // || r.RoomType.Contains(searchTerm)
        //        )
        //        .ToListAsync();
        //}

        //public async Task AddRoom(BE072024_HB_Rooms room)
        //{
        //    await _context.bE072024_HB_Rooms.AddAsync(room);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateRoom(BE072024_HB_Rooms room)
        //{
        //    _context.bE072024_HB_Rooms.Update(room);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteRoom(int id)
        //{
        //    var room = await _context.bE072024_HB_Rooms.FindAsync(id);
        //    if (room != null)
        //    {
        //        _context.bE072024_HB_Rooms.Remove(room);
        //        await _context.SaveChangesAsync();
        //    }
        //}
        public async Task<List<BE072024_HB_Rooms>> Room_GetAll(HB_RoomGetAllRequestData requestData)
        {
            var list = new List<BE072024_HB_Rooms>();
            try
            {
                list = _context.bE072024_HB_Rooms.ToList();
                if (!string.IsNullOrEmpty(requestData.RoomNumber))
                {
                    list = list.FindAll(s => s.RoomNumber.ToLower().Contains(requestData.RoomNumber.ToLower()));
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return list;
        }

        public async Task<ReturnData> Room_Insert(Room_InsertRequestData requestData)
        {
            var returnData = new ReturnData();

            try
            {
                if (requestData == null
                    || requestData.HotelID <= 0
                    || string.IsNullOrEmpty(requestData.RoomNumber)
                    || requestData.IsActive < 0)
                {
                    returnData.ReturnCode = -1;
                    returnData.ReturnMessage = "D? li?u không h?p l?";
                    return returnData;
                }

                var req = new BE072024_HB_Rooms
                {
                    HotelID = requestData.HotelID,
                    RoomNumber = requestData.RoomNumber,
                    RoomSquare = requestData.RoomSquare,
                    IsActive = requestData.IsActive
                };
                _context.bE072024_HB_Rooms.Add(req);

                var rs = _context.SaveChanges();// tr? v? s? dòng ???c thay ??i 
                if (rs == 0)
                {
                    returnData.ReturnCode = -2;
                    returnData.ReturnMessage = "Thêm m?i th?t b?i";
                    return returnData;
                }

                returnData.ReturnCode = 1;
                returnData.ReturnMessage = "Thêm m?i thành công";
                return returnData;

            }
            catch (Exception ex)
            {
                returnData.ReturnCode = -99;
                returnData.ReturnMessage = ex.Message;
                return returnData;
            }

        }
    }
}