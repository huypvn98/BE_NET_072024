using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO.Session9
{
    public class CongDoan
    {
        public string MaCongDoan { get; set; }
        public string TenCongDoan { get; set; }
        public int SoLuongSanPham { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get { return SoLuongSanPham * DonGia; } }
    }
}
