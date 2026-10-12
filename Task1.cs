//namespace DZ_06._10__Base_
//{
//    internal class Task1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введи число от 1 до 100");
//            int ask = int.Parse(Console.ReadLine());

//            while (ask < 1 || ask > 100)
//            {
//                Console.WriteLine("от 0 до 100");
//            }

//            if (ask % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (ask % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else if (ask % 5 == 0 || ask % 3 == 0)
//            {
//                Console.WriteLine("Buzz Fizz");
//            }
//            else
//            {
//                Console.WriteLine($"ТЫ ввел не вайбовое число: {ask}");
//            }
//        }
//    }
//}
