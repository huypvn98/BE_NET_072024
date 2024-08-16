using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public abstract class Employee
    {
        public string HoTen { get; set; }
        public string MaNV { get; set; }

        public Employee(string hoTen, string maNV)
        {
            HoTen = hoTen;
            MaNV = maNV;
        }

        public abstract double TinhLuong();
    }
}
