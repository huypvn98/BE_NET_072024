using BE072024.DataAcceess_NetFrameWork.DO.Session10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session10.Service
{
    public class BookingService : IBookingCreation, IBookingCancellation
    {
        private readonly IRoomRepository _roomRepository;
        private readonly List<Booking> _bookings;
        public BookingService(IRoomRepository roomRepository, List<Booking> bookings)
        {
            _roomRepository = roomRepository;
            _bookings = bookings;
        }

        public ActionResult CreateBooking(Booking booking)
        {
            try
            {
                var room = _roomRepository.GetRoomById(booking.RoomNumber);
                if (room != null)
                {
                    if (room.IsAvailable)
                    {
                        _bookings.Add(booking);
                        room.IsAvailable = false;
                        return new ActionResult { IsSuccess = true, Message = $"Đặt phòng thành công cho {booking.CustomerName} từ {booking.CheckInDate} đến {booking.CheckOutDate}!" };
                    }
                    return new ActionResult { IsSuccess = false, Message = "Phòng đã đặt." };
                }
                return new ActionResult { IsSuccess = false, Message = "Không tìm thấy phòng." };
            }
            catch (Exception ex) {
                return new ActionResult { IsSuccess = false, Message = ex.Message };
            }

        }

        public ActionResult CancelBooking(int bookingId)
        {
            try
            {
                var booking = _bookings.FirstOrDefault(b => b.BookingId == bookingId);
                if (booking != null)
                {
                    var room = _roomRepository.GetRoomById(booking.RoomNumber);
                    if (room != null)
                    {
                        room.IsAvailable = true;
                    }
                    _bookings.Remove(booking);
                    return new ActionResult { IsSuccess = true, Message = $"Hủy đặt phòng thành công cho {booking.CustomerName} từ {booking.CheckInDate} đến {booking.CheckOutDate}!" };
                }
                else
                {
                    return new ActionResult { IsSuccess = false, Message = "Không tìm thấy đơn đặt phòng." };
                }
            }
            catch (Exception ex)
            {
                return new ActionResult { IsSuccess = false, Message = ex.Message };
            }
            
        }
    }
}
