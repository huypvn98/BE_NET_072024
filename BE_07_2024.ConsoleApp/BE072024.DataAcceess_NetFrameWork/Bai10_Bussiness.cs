using BE072024.DataAcceess_NetFrameWork.DO.Session10;
using BE072024.DataAcceess_NetFrameWork.DO.Session10.Repository;
using BE072024.DataAcceess_NetFrameWork.DO.Session10.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork
{
    public class Bai10_Bussiness
    {
        private readonly IRoomRepository _roomRepository;
        private BookingService _bookingService;
        public Bai10_Bussiness(IRoomRepository roomRepository , List<Booking> bookings)
        {
            _roomRepository = roomRepository;
            _bookingService = new BookingService(roomRepository, bookings);
        }
        public void AddNewRoom(IRoomRepository roomRepository)
        {
            Console.Write("Nhập ID phòng: ");
            int roomId = int.Parse(Console.ReadLine());

            Console.WriteLine("Chọn loại phòng:");
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Deluxe");
            Console.WriteLine("3. Suite");
            Console.Write("Lựa chọn của bạn: ");
            int roomTypeChoice = int.Parse(Console.ReadLine());

            Room newRoom = roomTypeChoice switch
            {
                1 => new StandardRoom { RoomNumber = roomId },
                2 => new DeluxeRoom { RoomNumber = roomId },
                3 => new SuiteRoom { RoomNumber = roomId },
                _ => throw new ArgumentException("Lựa chọn không hợp lệ.")
            };

            roomRepository.AddRoom(newRoom);
        }

        public void CancelBooking(int bookingId)
        {
            Console.WriteLine("Cancel booking: " + bookingId);
        }

    }
}
