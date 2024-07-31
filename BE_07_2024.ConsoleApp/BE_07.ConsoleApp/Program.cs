using BE072024.Common_NetFrameWork.Common;
using BE072024.DataAcceess_NetFrameWork;
using BE072024.DataAcceess_NetFrameWork.DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BE_07.ConsoleApp
{
    internal class Program
    {
        int toancuc = 100; // toàn cục
        enum OPTION_CHAR
        {
            Y = 1,
            N = 0
        }

        enum OPTION_NUMBER
        {
            SUM_TWO_NUMBER = 1,
            MULTIPLY_TWO_NUMBER = 2,
            SUBTRACT_TWO_NUMBER = 3,
            SOLVE_LINEAR_EQUATION = 4,
            SOLVE_QUADRATIC_EQUATION = 5,
            CONVERT_C_TO_K = 6,
            CONVERT_C_TO_F = 7,
            FACTORIAL = 8,
            LIST_PRIME_NUMBER = 9,
            CHECK_EVEN_OR_ODD = 10,
            PRINT_ARRAY_ODD_NUMBER = 11,
            PRINT_ARRAY_EVEN_NUMBER = 12,
            SORT_ARRAY_ASCENDING = 13,
            SORT_ARRAY_DESCENDING = 14,
            DISPLAY_NUMBER_IN_WORDS = 15,
            CALCULATE_FRACTION = 16,
            STATISTICS_STUDY = 17
        }

        static void Main(string[] args)
        {
            int optionNumber = 0;
            string optionChar = "Y";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            loop2:
            Console.WriteLine("**************Hãy chọn thao tác cần thực hiện***************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.   Tính tổng 2 số.");
            Console.WriteLine("2.   Tính tích 2 số.");
            Console.WriteLine("3.   Tính hiệu 2 số."); 
            Console.WriteLine("4.   Giải phương trình bậc 1."); 
            Console.WriteLine("5.   Giải phương trình bậc 2.");
            Console.WriteLine("6.   Chuyển đổi độ C thành độ K.");
            Console.WriteLine("7.   Chuyển đổi độ C thành độ F.");
            Console.WriteLine("8.   Tính giai thừa của 1 số.");
            Console.WriteLine("9.   Liệt kê tất cả các số nguyên tố nhỏ hơn 1 số.");
            Console.WriteLine("10.  Kiểm tra một số là số chẵn hay số lẻ.");
            Console.WriteLine("11.  In ra mảng số lẻ từ một mảng số nguyên.");
            Console.WriteLine("12.  In ra mảng số chẵn từ một mảng số nguyên.");
            Console.WriteLine("13.  Sắp xếp mảng tăng dần.");
            Console.WriteLine("14.  Sắp xếp mảng giảm dần.");
            Console.WriteLine("15.  Hiển thị số bằng chữ.");
            Console.WriteLine("16.  Tính toán phân số.");
            Console.WriteLine("17.  Thống kê tình hình học tập của một lớp gồm 5 sinh viên.");
            Console.WriteLine("------------------------------------------------------------");

            loop:
            if(!ValidateData.CheckNullAndGreaterThanZero_Data(Console.ReadLine(), optionNumber))
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                goto loop;
            }    
                
            switch (optionNumber)
            { 
                case (int)OPTION_NUMBER.CALCULATE_FRACTION: 
                    int tuSo1, mauSo1, tuSo2, mauSo2;
                    Bai1_Bussiness.UserInput(tuSo1);
                    Console.WriteLine(); break;
                default: 
                    Console.WriteLine("Tính năng đang bảo trì!");               
                break;
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Bạn có muốn tiếp tục chương trình! (Y/N)");
            loop1:
            optionChar = Console.ReadLine().ToUpper();
            if (!Enum.GetNames(typeof(OPTION_CHAR)).Contains(optionChar))
            {            
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                goto loop1;
            }    
            if (optionChar == nameof(OPTION_CHAR.Y))
            {
                Console.WriteLine("------------------------------------------------------------");
                goto loop2;
            }

            Console.WriteLine("Kết thúc chương trình!");
            Environment.Exit(0);
        }


    }
}
