using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo 1 mảng arr để chứa các số nguyên 
            int[] arr = new int[] { };
            bool isValidInput = false;
            try
            {
                while (!isValidInput)
                {
                    Console.Write("Nhập mảng số nguyên bất kỳ (ngăn cách bởi dấu ','): ");
                    string input = Console.ReadLine();
                    //Ràng buộc người dùng nhập vào một mảng số nguyên, ngăn cách bởi dấu ','
                    string[] strArr = input.Split(',');
                    arr = new int[strArr.Length];
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        isValidInput = int.TryParse(strArr[i], out arr[i]);
                        if (!isValidInput)
                        {
                            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                            break;
                        }
                    }
                }
                Array.Sort(arr);
                Console.WriteLine("Mảng số nguyên tăng dần: " + string.Join(", ", arr));
                Array.Reverse(arr);
                Console.WriteLine("Mảng số nguyên giảm dần: " + string.Join(", ", arr));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
