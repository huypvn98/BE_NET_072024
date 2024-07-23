using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
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
                Console.WriteLine(string.Format("Danh sách số nguyên tố nhỏ hơn {0} là:", number));
                ListPrimes(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void ListPrimes(int n)
        {
            try
            {
                for (int i = 2; i < n; i++)
                {
                    if (IsPrime(i))
                        Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        static bool IsPrime(int n)
        {
            try
            {
                if (n <= 1)
                    return false;
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            
        }

    }
}
