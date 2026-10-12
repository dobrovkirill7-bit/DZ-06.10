using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace DZ_06._10__Base_
{
    internal class Task8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пиши первое число: ");
            int ask1 = int.Parse(Console.ReadLine());

            string count = ask1.ToString();
            int[] temp = new int[ask1];

            double result = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                result = result + Math.Pow(temp[i], count.Length);
                i++;
            }

            if (result == ask1)
            {
                Console.WriteLine($"{ask1} это число Амстронга");
            }
            else
            {
                Console.WriteLine($"{ask1} это фигня а не число Амстронга");
            }
        }
    }
}
