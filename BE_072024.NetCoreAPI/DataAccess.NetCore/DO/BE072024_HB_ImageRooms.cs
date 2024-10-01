using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class BE072024_HB_ImageRooms
    {
        [Key]
        public int Id { get; set; }

        public string NameFileImg { get; set; }

        [ForeignKey("RoomID")]
        public virtual BE072024_HB_Rooms Room { get; set; }
    }
}
