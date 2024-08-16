using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public class Intern : Employee
    {
        public double TroCap { get; set; }

        public Intern(string hoTen, string maNV, double troCap)
    : base(hoTen, maNV)
        {
            TroCap = troCap;
        } 

        public override double TinhLuong()
        {
            return TroCap;
        }
    }
}
