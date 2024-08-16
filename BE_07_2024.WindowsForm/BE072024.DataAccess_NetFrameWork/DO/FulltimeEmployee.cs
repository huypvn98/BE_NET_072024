using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public class FulltimeEmployee : Employee
    {
        public double LuongCoBan { get; set; }
        public double PhuCap { get; set; }

        public FulltimeEmployee(string hoTen, string maNV, double luongCoBan, double phuCap)
    : base(hoTen, maNV)
        {
            LuongCoBan = luongCoBan;
            PhuCap = phuCap;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + PhuCap;
        }
    }
}
