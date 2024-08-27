using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO
{
    public class NhanVien
    {
        private string hoTen;
        private string maNhanVien;
        private double luongCoBan;

        public NhanVien(string hoTen, string maNhanVien, double luongCoBan)
        {
            this.hoTen = hoTen;
            this.maNhanVien = maNhanVien;
            this.luongCoBan = luongCoBan;
        }

        public string HoTen()
        {
            return hoTen; 
        }

        public string MaNhanVien()
        {
            return maNhanVien;
        }

        public virtual double TinhLuong()
        {
            return luongCoBan;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {hoTen}, Mã nhân viên: {maNhanVien}, Lương: {TinhLuong()}");
        }
    }
}
