//using System;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace DZ_06._10__Base_
//{
//    internal class Task6
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Впиши сюда температуры: ");
//            int temparatura = int.Parse(Console.ReadLine());

//            Console.WriteLine("===== МЕНЮ =====");
//            Console.WriteLine("1) Перевести значення из Фаренгейта в Цельсию");
//            Console.WriteLine("2) Перевести значення из Цельсию в Фаренгейта");
//            Console.Write("Твой ответ: ");
//            int ask = int.Parse(Console.ReadLine());
//            if (ask < 1 || ask > 2)
//            {
//                Console.WriteLine("АШИБКА");
//            }
//            else if (ask == 1)
//            {
//                Console.WriteLine($"{(temparatura - 32) * 5 / 9}");
//            }
//            else
//            {
//                Console.WriteLine($"{(temparatura * 9 / 5) + 32}");
//            }
//        }
//    }
//}
