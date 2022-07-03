using System;

namespace FunctionsTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (ConvertToNumber(ref number) == false)
            {
                Console.WriteLine("Ошибка конвертации!");
            }

            Console.WriteLine($"Число {number} успешно было сконвертированно из строки");
        }

        static bool ConvertToNumber(ref int number)
        {
            Console.WriteLine("Введите число");

            return int.TryParse(Console.ReadLine(), out number);
        }
    }
}
