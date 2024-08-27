using BE072024.Common_NetFrameWork.Common;
using BE072024.DataAcceess_NetFrameWork.DO.Session9;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static BE072024.DataAcceess_NetFrameWork.DO.Enum.bai8_Option;

namespace BE072024.DataAcceess_NetFrameWork
{
    public class Bai9_Bussiness
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
            }
        }

        public void ThemNhanVien()
        {
            NhanVien nv = new NhanVien();
            Console.Write("Nhập ID: ");
            nv.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên: ");
            nv.Ten = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            nv.GioiTinh = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            nv.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập lương cơ bản: ");
            nv.LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số lương: ");
            nv.HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập phụ cấp: ");
            nv.PhuCap = double.Parse(Console.ReadLine());

            danhSachNhanVien.Add(nv);
            Console.WriteLine("Thêm nhân viên thành công!");
        }

        public void TimKiemNhanVien()
        {
            Console.Write("Nhập ID nhân viên cần tìm: ");
            int id = int.Parse(Console.ReadLine());
            NhanVien nv = danhSachNhanVien.Find(n => n.Id == id);

            if (nv != null)
            {
                Console.WriteLine($"ID: {nv.Id}, Tên: {nv.Ten}, Giới tính: {nv.GioiTinh}, Tuổi: {nv.Tuoi}, Lương cơ bản: {nv.LuongCoBan}, Hệ số lương: {nv.HeSoLuong}, Phụ cấp: {nv.PhuCap}, Tổng lương: {nv.TongLuong}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên!");
            }
        }

        public void TaoSanLuong()
        {
            Console.Write("Nhập ID nhân viên: ");
            int id = int.Parse(Console.ReadLine());
            NhanVien nv = danhSachNhanVien.Find(n => n.Id == id);

            if (nv != null)
            {
                CongDoan cd = new CongDoan();
                Console.Write("Nhập mã công đoạn: ");
                cd.MaCongDoan = Console.ReadLine();
                Console.Write("Nhập tên công đoạn: ");
                cd.TenCongDoan = Console.ReadLine();
                Console.Write("Nhập số lượng sản phẩm: ");
                cd.SoLuongSanPham = int.Parse(Console.ReadLine());
                Console.Write("Nhập đơn giá sản phẩm: ");
                cd.SoLuongSanPham = int.Parse(Console.ReadLine());

                nv.CongDoans.Add(cd);
                Console.WriteLine("Thêm công đoạn thành công!");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên!");
            }
        }

        public void XuatBaoCao()
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("BaoCao");

                // Tiêu đề cột
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Tên";
                worksheet.Cells[1, 3].Value = "Giới Tính";
                worksheet.Cells[1, 4].Value = "Tuổi";
                worksheet.Cells[1, 5].Value = "Lương Cơ Bản";
                worksheet.Cells[1, 6].Value = "Hệ Số Lương";
                worksheet.Cells[1, 7].Value = "Phụ Cấp";
                worksheet.Cells[1, 8].Value = "Tổng Lương";
                worksheet.Cells[1, 9].Value = "Mã Công Đoạn";
                worksheet.Cells[1, 10].Value = "Tên Công Đoạn";
                worksheet.Cells[1, 11].Value = "Số Lượng Sản Phẩm";

                int row = 2;
                int startRow = row;

                foreach (var nv in danhSachNhanVien)
                {
                    foreach (var cd in nv.CongDoans)
                    {
                        worksheet.Cells[row, 1].Value = nv.Id;
                        worksheet.Cells[row, 2].Value = nv.Ten;
                        worksheet.Cells[row, 3].Value = nv.GioiTinh;
                        worksheet.Cells[row, 4].Value = nv.Tuoi;
                        worksheet.Cells[row, 5].Value = nv.LuongCoBan;
                        worksheet.Cells[row, 6].Value = nv.HeSoLuong;
                        worksheet.Cells[row, 7].Value = nv.PhuCap;
                        worksheet.Cells[row, 8].Value = nv.TongLuong;
                        worksheet.Cells[row, 9].Value = cd.MaCongDoan;
                        worksheet.Cells[row, 10].Value = cd.TenCongDoan;
                        worksheet.Cells[row, 11].Value = cd.SoLuongSanPham;
                        row++;
                    }

                    // Thêm dòng tổng cho từng nhân viên
                    worksheet.Cells[row, 1].Value = "Tổng";
                    worksheet.Cells[row, 8].Formula = $"SUM(H{row - nv.CongDoans.Count}:H{row - 1})";
                    worksheet.Cells[row, 11].Formula = $"SUM(K{row - nv.CongDoans.Count}:K{row - 1})";
                    row++;
                }

                // Thêm dòng tổng cho tất cả các dòng tổng
                worksheet.Cells[startRow, 1].Value = "Tổng tất cả";
                worksheet.Cells[startRow, 8].Formula = $"SUM(H{startRow + 1}:H{row - 1})";
                worksheet.Cells[startRow, 11].Formula = $"SUM(K{startRow + 1}:K{row - 1})";

                // Lưu file
                FileInfo fileInfo = new FileInfo("BaoCao.xlsx");
                package.SaveAs(fileInfo);
                Console.WriteLine("Xuất báo cáo ra Excel thành công!");
            }
        }
    }
}
