using BE072024.DataAcceess_NetFrameWork.DO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session9
{
    public class NhanVien : INhanVien
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }
        public double PhuCap { get; set; }
        public double TongLuong { get; set; }
        public List<CongDoan> CongDoans { get; set; } = new List<CongDoan>();

        public void TinhLuong()
        {
            TongLuong = LuongCoBan* HeSoLuong +PhuCap;
        }
    }
}
