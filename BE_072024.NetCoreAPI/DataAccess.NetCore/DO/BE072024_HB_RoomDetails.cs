using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class BE072024_HB_RoomDetails
    {
        [Key]
        public int RoomDetailID { get; set; }
        [ForeignKey("RoomID")]
        public virtual BE072024_HB_Rooms Room { get; set; }
        public string RoomFittings { get; set; }
        public string RoomView { get; set; }
        public string RoomType { get; set; }
        public int PricePerNight { get; set; }
        public int IsAvailable { get; set; }
    }
}
