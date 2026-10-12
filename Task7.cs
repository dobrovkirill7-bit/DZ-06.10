//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DZ_06._10__Base_
//{
//    internal class Task7
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Пиши первое число: ");
//            int ask1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Пиши 2 число: ");
//            int ask2 = int.Parse(Console.ReadLine());

//            int temp;
//            if (ask1 > ask2)
//            {
//                Console.WriteLine("Сказано ведь, что диапазон ОТ и ДО!");
//                temp = ask1;
//                ask1 = ask2;
//                ask2 = temp;
//            }
            
//            for (int i = ask1; i <= ask2; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine($"{i}");
//                }
//            }
//        }
//    }
//}
