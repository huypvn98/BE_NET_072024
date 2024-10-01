using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class BE072024_HB_BedRoom
    {
        [Key, Column(Order = 0)]
        public int RoomID { get; set; }

        [Key, Column(Order = 1)]
        public int BedID { get; set; }

        public int Quantity { get; set; }
    }
}
