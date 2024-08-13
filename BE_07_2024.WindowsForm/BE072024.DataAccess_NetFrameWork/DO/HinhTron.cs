using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public class HinhTron : HinhHoc
    {
        private double banKinh;

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * Math.Pow(this.banKinh, 2);
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * this.banKinh;
        }
    }
}
