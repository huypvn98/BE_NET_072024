using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số thứ nhất: ");
            //Kiểm tra biến num1 có phải là số không


            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double product = num1 * num2;
            double difference = num1 - num2;

            Console.WriteLine("Tổng của hai số là: " + sum);
            Console.WriteLine("Tích của hai số là: " + product);
            Console.WriteLine("Hiệu của hai số là: " + difference);
        }


    }
}
