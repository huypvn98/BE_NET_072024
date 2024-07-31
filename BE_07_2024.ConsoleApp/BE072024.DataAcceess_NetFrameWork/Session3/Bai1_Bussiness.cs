using BE072024.Common_NetFrameWork.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork
{
    public class Bai1_Bussiness
    {

        //<kiểu trả về > <tên hàm> (<tham sô> , <tham số>);

        // tham trị -> truyền giá trị vào biến
        public int TongHaiSo(int soThuNhat, int soThuHai)
        {
            try
            {
                soThuHai = 0;
                var tong = soThuNhat / soThuHai;
                return tong;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Message :{0}", ex.Message);
                Console.WriteLine("StackTrace :{0}", ex.StackTrace);
                Console.WriteLine("Source :{0}", ex.Source);
                throw ex;
            }
            finally
            {
                Console.WriteLine("finally");
            }

            return 0;
        }

        public int TraHaiGiaTri(int a, out int TotalRecord)
        {
            TotalRecord = 200;
            return 100;
        }

        public void Tong(int sothunhat, int sothu2)
        {
            ///
        }

        List<int> DanhSachSo()
        {
            return new List<int>();
        }
        public void UserInput(int tuSo)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tử số cho phân số thứ nhất: ");
            //var isvalid = BE072024.Common_NetFrameWork.Common.ValidateData.CheckNull_Data(s);
            loop:
            if (!ValidateData.CheckMauSoKhacKhong(Console.ReadLine(), tuSo))
            {
                goto loop;
            }
            if (s.Length > 2)
            {
                // Exception e = new DataTooLongExeption();
                //  throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

        public void ThamChieu(ref int bien_duoc_tham_chieu)
        {
            bien_duoc_tham_chieu = bien_duoc_tham_chieu * bien_duoc_tham_chieu;
            Console.WriteLine(bien_duoc_tham_chieu);

        }

        public void ThamChieuWith_Out(out int bien)
        {
            bien = 10000;
        }
    }
}
