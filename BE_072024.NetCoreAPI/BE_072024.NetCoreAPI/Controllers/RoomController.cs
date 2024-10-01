using DataAccess.NetCore.DO;
using DataAccess.NetCore.IServices;
using DataAccess.NetCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BE_072024.NetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomGenericRepository _roomGenericRepository;
        private IUnitOfWork _unitOfWork;
        public RoomController(IRoomGenericRepository roomGenericRepository, IUnitOfWork unitOfWork)
        {
            _roomGenericRepository = roomGenericRepository;
            _unitOfWork = unitOfWork;
        }
        //[HttpPost("Room_GetAll")]
        //public async Task<ActionResult> Room_GetAll(HB_RoomGetAllRequestData requestData)
        //{
        //    var list = new List<BE072024_HB_Rooms>();
        //    try
        //    {
        //        //list = await _roomServices.Room_GetAll(requestData);
        //        list = await _roomGenericRepository.GetAll();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //    return Ok(list);
        //}

        //[HttpPost("Room_Insert")]
        //public async Task<ActionResult> Room_Insert(Room_InsertRequestData requestData)
        //{
        //    try
        //    {
        //        // var rs = await _roomServices.Room_Insert(requestData);
        //        var request_hotel = new BE072024_HB_Hotels
        //        {
        //            CreatedDate = DateTime.Now,
        //            HotelName = "HOTEL_TEST",
        //            Description = "abc",
        //        };

        //        var room_request = new BE072024_HB_Rooms
        //        {
        //            HotelID = requestData.HotelID,
        //            IsActive = requestData.IsActive,
        //            RoomNumber = requestData.RoomNumber,
        //            RoomSquare = requestData.RoomSquare,
        //        };

        //        await _unitOfWork._hotelGenericRepository.Insert(request_hotel);

        //        await _unitOfWork._roomGenericRepository.Insert(room_request);

        //        var rs = _unitOfWork.SaveChange();


        //        return Ok(rs);
        //    }
        //    catch (Exception EX)
        //    {

        //        throw;
        //    }
        //}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BE072024_HB_Rooms>>> GetAllRooms()
        {
            var rooms = await _roomGenericRepository.GetAll();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BE072024_HB_Rooms>> GetRoomById(int id)
        {
            var room = await _roomGenericRepository.GetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        //[HttpGet("search")]
        //public async Task<ActionResult<IEnumerable<BE072024_HB_Rooms>>> SearchRooms([FromQuery] string searchTerm)
        //{
        //    var rooms = await _roomRepository.SearchRooms(searchTerm);
        //    return Ok(rooms);
        //}

        [HttpPost]
        public async Task<ActionResult<BE072024_HB_Rooms>> AddRoom(BE072024_HB_Rooms room)
        {
            await _roomGenericRepository.AddRoom(room);
            return CreatedAtAction(nameof(GetRoomById), new { id = room.RoomID }, room);
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateRoom(int id, BE072024_HB_Rooms room)
        //{
        //    if (id != room.RoomID)
        //    {
        //        return BadRequest();
        //    }

        //    await _roomRepository.UpdateRoom(room);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteRoom(int id)
        //{
        //    await _roomRepository.DeleteRoom(id);
        //    return NoContent();
        //}
    }

}
