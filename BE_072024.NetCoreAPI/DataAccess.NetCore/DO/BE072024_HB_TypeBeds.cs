using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DO
{
    public class TypeBed
    {
        [Key]
        public int BedID { get; set; }
        public string NameBed { get; set; }
        public int Quantity { get; set; }

    }
}
