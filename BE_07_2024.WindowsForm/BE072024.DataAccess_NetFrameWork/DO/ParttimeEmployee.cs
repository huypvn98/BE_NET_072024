using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public class ParttimeEmployee : Employee
    {
        public double LuongTheoGio { get; set; }
        public int SoGioLam { get; set; }

        public ParttimeEmployee(string hoTen, string maNV, double luongTheoGio, int soGioLam)
        : base(hoTen, maNV)
        {
            LuongTheoGio = luongTheoGio;
            SoGioLam = soGioLam;
        }

        public override double TinhLuong()
        {
            return LuongTheoGio * SoGioLam;
        }
    }
}
