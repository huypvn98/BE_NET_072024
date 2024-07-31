using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO
{
    public struct PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        public PhanSo Cong(PhanSo ps)
        {
            int tuSo = TuSo * ps.MauSo + ps.TuSo * MauSo;
            int mauSo = MauSo * ps.MauSo;
            return new PhanSo(tuSo, mauSo);
        }

        public PhanSo Tru(PhanSo ps)
        {
            int tuSo = TuSo * ps.MauSo - ps.TuSo * MauSo;
            int mauSo = MauSo * ps.MauSo;
            return new PhanSo(tuSo, mauSo);
        }

        public PhanSo Nhan(PhanSo ps)
        {
            int tuSo = TuSo * ps.TuSo;
            int mauSo = MauSo * ps.MauSo;
            return new PhanSo(tuSo, mauSo);
        }

        public PhanSo Chia(PhanSo ps)
        {
            int tuSo = TuSo * ps.MauSo;
            int mauSo = MauSo * ps.TuSo;
            return new PhanSo(tuSo, mauSo);
        }
    }
}
