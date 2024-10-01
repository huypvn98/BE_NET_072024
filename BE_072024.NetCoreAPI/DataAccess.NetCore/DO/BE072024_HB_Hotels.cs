using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class BE072024_HB_TypeBeds
    {
        [Key]
        public int HotelID { get; set; }
        public string? HotelName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class HB_HotelGetAllRequestData
    {
        public string? RoomNumber { get; set; }
    }

    public class Hotel_InsertRequestData
    {
        public string? HotelName { get; set; }
        public string? Description { get; set; }
        public int IsActive { get; set; }
    }
}
