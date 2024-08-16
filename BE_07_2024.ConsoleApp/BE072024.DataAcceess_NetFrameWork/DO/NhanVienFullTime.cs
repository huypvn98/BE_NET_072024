using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO
{
    public class NhanVienFullTime : NhanVien
    {
        private double thuong;

        public NhanVienFullTime(string hoTen, string maNhanVien, double luongCoBan, double thuong)
            : base(hoTen, maNhanVien, luongCoBan)
        {
            this.thuong = thuong;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + thuong;
        }

        //public override void HienThiThongTin()
        //{
        //    base.HienThiThongTin();
        //    Console.WriteLine($"Tiền thưởng: {thuong}");
        //}

        public double Thuong()
        {
            return thuong;
        }

    }
}
