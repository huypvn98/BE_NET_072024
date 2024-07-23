using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a = 0;
            double b = 0;
            double x = 0;
            loop:
            Console.WriteLine("Giải phương trình bậc mấy: ");
            switch (Convert.ToDouble(Console.ReadLine()))
            {
                case 1:
                    // Giải phương trình bậc nhất
                    Console.Write("Nhập a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhập b: ");
                        b = Convert.ToDouble(Console.ReadLine());

                    if (a == 0)
                    {
                        if (b == 0)
                            Console.WriteLine("Phương trình vô số nghiệm");
                        else
                            Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else
                    {
                        x = -b / a;
                        Console.WriteLine("Nghiệm của phương trình là: " + x);
                    }
                break;

                case 2:
                    // Giải phương trình bậc hai
                    Console.Write("Nhập a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhập b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhập c: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else if (delta == 0)
                    {
                        x = -b / (2 * a);
                        Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + x);
                    }
                    else
                    {
                        double sqrtDelta = Math.Sqrt(delta);
                        double x1 = (-b + sqrtDelta) / (2 * a);
                        double x2 = (-b - sqrtDelta) / (2 * a);
                        Console.WriteLine("Phương trình có hai nghiệm phân biệt x1 = " + x1 + ", x2 = " + x2);
                    }
                    break;
                default:
                    Console.WriteLine("Giá trị không hợp lệ! Vui lòng nhập lại.");
                    goto loop;
            }                     
        }
    }
}
