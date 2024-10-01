using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class BE072024_HB_Rooms
    {
        [Key] 
        public int RoomID { get; set; }
        public int HotelID { get; set; }
        public string? RoomNumber { get; set; }
        public int RoomSquare { get; set; }
        public int IsActive { get; set; }
        [ForeignKey("HotelID")]
        public virtual BE072024_HB_TypeBeds Hotel { get; set; }

    }
    public class HB_RoomGetAllRequestData
    {
        public string? RoomNumber { get; set; }
    }

    public class Room_InsertRequestData
    {
        public int HotelID { get; set; }
        public string? RoomNumber { get; set; }
        public int RoomSquare { get; set; }
        public int IsActive { get; set; }
    }
}
