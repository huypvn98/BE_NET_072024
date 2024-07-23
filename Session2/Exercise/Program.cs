using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
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
                    Console.Write("Nhập số nguyên không âm để tính giai thừa: ");
                    string input = Console.ReadLine();

                    isValidInput = int.TryParse(input, out number) && number >= 0;

                    if (!isValidInput)
                    {
                        Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                    }
                }

                // Gọi phương thức tính giai thừa với giá trị nhập vào
                Console.WriteLine($"Giai thừa của {number} là: {Factorial(number)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
                
           
        }

        static int Factorial(int n)
        {
           try
           {
                if (n == 0)
                    return 1;
                return n * Factorial(n - 1);
           }
           catch (Exception ex)
           {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return 0;
           }

        }
    }
}
