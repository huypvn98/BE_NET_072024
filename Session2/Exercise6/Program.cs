using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int number = 0; // Initialize number with a default value
            bool isValidInput = false;
            try
            {
                while (!isValidInput)
                {
                    Console.Write("Nhập số nguyên bất kỳ: ");
                    string input = Console.ReadLine();

                    isValidInput = int.TryParse(input, out number);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                    }
                }
                Console.WriteLine(string.Format("Số {0} là số {1}", number, EvenOrOdd(number)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        static string EvenOrOdd(int n)
        {
            try
            {
                return n % 2 == 0 ? "chẵn" : "lẻ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return string.Empty;
            }
            
        }

    }
}
