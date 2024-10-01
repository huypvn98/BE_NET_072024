using DataAccess.NetCore.DO;
using DataAccess.NetCore.IServices;
using DataAccess.NetCore.Services;
using DataAccess.NetCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BE_072024.NetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        //private IRoomRepository _roomServices;
        private IHotelGenericRepository _hotelGenericRepository;
        private IUnitOfWork _unitOfWork;
        private readonly ILogger<HotelController> _logger;
        public HotelController(
            ILogger<HotelController> logger,
            IHotelGenericRepository hotelGenericRepository, 
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _hotelGenericRepository = hotelGenericRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<BE072024_HB_TypeBeds>>> GetAllHotels([FromQuery] string keyword = "")
        {
            try
            {
                var hotels = await _hotelGenericRepository.GetAll();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    hotels = hotels.Where(h => h.HotelName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || h.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                                        .ToList();
                }

                return Ok(hotels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAllHotels");
                return StatusCode(500, new { error = "An error occurred while processing your request.", details = ex.Message });
            }
        }

        [HttpPost("Insert")]
        public async Task<ActionResult<int>> InsertHotel(Hotel_InsertRequestData requestData)
        {
            try
            {
                var newHotel = new BE072024_HB_TypeBeds
                {
                    CreatedDate = DateTime.UtcNow,
                    HotelName = requestData.HotelName,
                    Description = requestData.Description,
                };

                await _unitOfWork._hotelGenericRepository.Insert(newHotel);

                var rs = _unitOfWork.SaveChange();


                return Ok(rs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in InsertHotel");
                return StatusCode(500, new { error = "An error occurred while processing your request.", details = ex.Message });
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult> UpdateHotel(int id, Hotel_InsertRequestData requestData)
        {
            try
            {
                var existingHotel = await _hotelGenericRepository.GetById(id);
                if (existingHotel == null)
                {
                    return NotFound($"Hotel with ID {id} not found.");
                }

                existingHotel.HotelName = requestData.HotelName;
                existingHotel.Description = requestData.Description;
                // Update other properties as needed

                await _unitOfWork._hotelGenericRepository.Update(existingHotel);
                var affectedRows = _unitOfWork.SaveChange();

                return Ok(affectedRows);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error in UpdateHotel for ID {id}");
                return StatusCode(500, new { error = "An error occurred while processing your request.", details = ex.Message });
            }
        }
        
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> DeleteHotel(int id)
        {
            try
            {
                var existingHotel = await _hotelGenericRepository.GetById(id);
                if (existingHotel == null)
                {
                    return NotFound($"Hotel with ID {id} not found.");
                }

                await _unitOfWork._hotelGenericRepository.Delete(existingHotel);
                var affectedRows = _unitOfWork.SaveChange();

                return Ok(affectedRows);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error in DeleteHotel for ID {id}");
                return StatusCode(500, new { error = "An error occurred while processing your request.", details = ex.Message });
            }
        }
    }
}
