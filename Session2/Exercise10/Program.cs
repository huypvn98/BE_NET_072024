using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
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
                    Console.Write("Nhập số nguyên không âm bất kỳ: ");
                    string input = Console.ReadLine();

                    isValidInput = int.TryParse(input, out number) && number >= 0;

                    if (!isValidInput)
                    {
                        Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                    }
                }
                string inWords = number.ToWords(new System.Globalization.CultureInfo("vi-VN"));

                Console.WriteLine("Số bằng chữ: " + inWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
