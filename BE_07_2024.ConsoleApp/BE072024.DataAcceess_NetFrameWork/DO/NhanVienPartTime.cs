using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO
{
    public class NhanVienPartTime : NhanVien
    {
        private int soGioLamViec;
        private double luongGio;

        public NhanVienPartTime(string hoTen, string maNhanVien, double luongCoBan, int soGioLamViec, double luongGio)
            : base(hoTen, maNhanVien, luongCoBan)
        {
            this.soGioLamViec = soGioLamViec;
            this.luongGio = luongGio;
        }

        public override double TinhLuong()
        {
            return soGioLamViec * luongGio;
        }

        //public override void HienThiThongTin()
        //{
        //    base.HienThiThongTin();
        //    Console.WriteLine($"Số giờ làm việc: {soGioLamViec}, Lương giờ: {luongGio}");
        //}

        public int SoGioLamViec()
        {
            return soGioLamViec;
        }

        public double LuongGio()
        {
            return luongGio; 
        }
    }
}
