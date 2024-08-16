using BE072024.Common_NetFrameWork.Common;
using BE072024.DataAcceess_NetFrameWork.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static BE072024.DataAcceess_NetFrameWork.DO.Enum.bai8_Option;

namespace BE072024.DataAcceess_NetFrameWork
{
    public class Bai8_Bussiness
    {
        List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public void loadMenu ()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            string tiepTuc;
            do
            {
                Console.WriteLine("**************Hãy chọn thao tác cần thực hiện***************");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("1. Nhập thông tin nhân viên");
                Console.WriteLine("2. Hiển thị danh sách nhân viên");
                Console.WriteLine("------------------------------------------------------------");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        do
                        {
                            NhapThongTinNhanVien();
                            Console.WriteLine("Bạn có muốn nhập tiếp không? (Y/N)");
                            tiepTuc = Console.ReadLine();
                            if (tiepTuc.ToUpper() == "N")
                            {
                                break;
                            }

                        } while (true);
                        
                        break;
                    case 2:
                            HienThiDanhSachNhanVien();
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
                Console.WriteLine("Bạn có muốn thao tác tiếp không? (Y/N)");
                tiepTuc = Console.ReadLine();
                if (tiepTuc.ToUpper() == "N")
                {
                    break;
                }
            } while (choice != 3);
        }


        public void NhapThongTinNhanVien()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string errorMessage = string.Empty;
            Console.WriteLine("Chọn loại nhân viên:");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1. Fulltime");
            Console.WriteLine("2. Parttime");
            Console.WriteLine("3. Thoát");
            Console.WriteLine("------------------------------------------------------------");

            l1:
            string loaiNhanVien = Console.ReadLine();
            if(!ValidateData.IsInt(loaiNhanVien, "Tùy chọn", out errorMessage, out int value))
            {
                Console.WriteLine(errorMessage);
                goto l1;
            }

            if(Enum.GetName(typeof(workingForm), value) == null)
            {
                Console.WriteLine("Tùy chọn không hợp lệ.");
                goto l1;
            }

            if(value == (int)workingForm.DEFAULT) 
            {
                return;
            }

            l0:
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            if(!ValidateData.IsValidName(hoTen, "Họ tên", out errorMessage))
            {
                Console.WriteLine(errorMessage);
                goto l0;
            }

            l2:
            Console.Write("Mã nhân viên: ");
            string maNhanVien = Console.ReadLine();
            if (!ValidateData.IsValidText(maNhanVien, "Mã nhân viên", out errorMessage))
            {
                Console.WriteLine(errorMessage);
                goto l2;
            }

            if (value == (int)workingForm.FULL_TIME)
            {
                l3:
                Console.Write("Lương cơ bản: ");
                if(!ValidateData.IsDoubleAndGreaterThanZero(Console.ReadLine(), "Lương cơ bản", out errorMessage, out double luongCoBan))
                {
                    Console.WriteLine(errorMessage);
                    goto l3;
                }    

                l4:
                Console.Write("Tiền thưởng: ");
                if (!ValidateData.IsDoubleAndGreaterThanZero(Console.ReadLine(), "Tiền thưởng", out errorMessage, out double thuong))
                {
                    Console.WriteLine(errorMessage);    
                    goto l4;
                }

                NhanVienFullTime nvft = new NhanVienFullTime(hoTen, maNhanVien, luongCoBan, thuong);
                danhSachNhanVien.Add(nvft);
            }
            else 
            {
                l5:
                Console.Write("Số giờ làm việc: ");
                if (!ValidateData.IsIntAndGreaterThanZero(Console.ReadLine(), "Số giờ làm", out errorMessage, out int soGioLamViec))
                {
                    Console.WriteLine(errorMessage);
                    goto l5;
                }

                l6:
                Console.Write("Lương giờ: ");
                if (!ValidateData.IsDoubleAndGreaterThanZero(Console.ReadLine(), "Lương giờ", out errorMessage, out double luongGio))
                {
                    Console.WriteLine(errorMessage);
                    goto l6;
                }

                NhanVienPartTime nvpt = new NhanVienPartTime(hoTen, maNhanVien, 0, soGioLamViec, luongGio);
                danhSachNhanVien.Add(nvpt);
            }
        }

        public void HienThiDanhSachNhanVien()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            foreach (var nhanVien in danhSachNhanVien)
            {
                nhanVien.HienThiThongTin();
                Console.WriteLine();
            }
        }
    }
}
