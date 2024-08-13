using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFrameWork.DO
{
    public class HinhChuNhat : HinhHoc
    {
        private double dai;
        private double rong;

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public override double TinhDienTich()
        {
            return this.dai * this.rong;
        }

        public override double TinhChuVi()
        {
            return 2 * (this.dai + this.rong);
        }
    }
}
