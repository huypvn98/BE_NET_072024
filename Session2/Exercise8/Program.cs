﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
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
                PrintEvenNumbers(arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        static void PrintEvenNumbers(int[] arr)
        {
            try
            {
                List<int> evenNumbers = new List<int>();
                foreach (int num in arr)
                {
                    if (num % 2 == 0)
                        evenNumbers.Add(num);
                }
                if(evenNumbers.Count == 0)
                {
                    Console.WriteLine("Không có số chẵn nào trong mảng.");
                }
                else
                {
                    Console.WriteLine("Các số chẵn trong mảng: {0}", evenNumbers.Select(n => n.ToString()).Aggregate((s1, s2) => s1 + ", " + s2));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
