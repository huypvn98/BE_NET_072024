using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập độ C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Chuyển đổi từ độ C sang độ K
            double k = c + 273.15;
            Console.WriteLine("Độ K là: " + k);

            // Chuyển đổi từ độ C sang độ F
            double f = c * 9 / 5 + 32;
            Console.WriteLine("Độ F là: " + f);
        }
    }
}
