using System;

namespace FunctionsTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите число: ");
            number = ConvertToNumber();
            Console.WriteLine($"Число {number} успешно было сконвертированно из строки");
        }

        static int ConvertToNumber()
        {
            int number;

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine("Ошибка конвертации! Введите повторно число: ");
            }

            return number;
        }
    }
}
