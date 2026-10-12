//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DZ_06._10__Base_
//{
//    internal class Task5
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введи день: ");
//            int day = int.Parse(Console.ReadLine());

//            if (day > 31 || day < 1)
//            {
//                Console.WriteLine("Я календарь");
//            }

//            Console.WriteLine("Введи месяц: ");
//            int mounth = int.Parse(Console.ReadLine());

//            if (mounth > 12 || mounth < 1)
//            {
//                Console.WriteLine("Я календарь");
//            }

//            Console.WriteLine("Введи год: ");
//            int year = int.Parse(Console.ReadLine());


//            var season = new Dictionary<int, string>() // это узнал отсюда https://metanit.com/sharp/tutorial/4.9.php
//            {
//                {1, "Winter"},
//                {2, "Winter"},
//                {3, "Spring"},
//                {4, "Spring"},
//                {5, "Spring"},
//                {6, "Summer"},
//                {7, "Summer"},
//                {8, "Summer"},
//                {9, "Atum"},
//                {10, "Atum"},
//                {11, "Atum"},
//                {12, "Winter"},
//            };
//            DateTime someDate = new DateTime(year, mounth, day);
//            Console.WriteLine($"{season[mounth]} {someDate.DayOfWeek}"); // это отсюда - https://metanit.com/sharp/tutorial/19.1.php
//        }
//    }
//}
