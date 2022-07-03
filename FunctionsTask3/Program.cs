using System;

namespace FunctionsTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isConverted = false;
            int number = 0;

            while (isConverted == false)
            {
                Console.WriteLine("Введите число");
                number = ConvertToNumber(ref isConverted);

                if (isConverted == false)
                {
                    Console.WriteLine("Ошибка конвертации!");
                }
            }

            Console.WriteLine($"Число {number} успешно было сконвертированно из строки");
        }

        static int ConvertToNumber(ref bool isConverted)
        {
            int number;
            isConverted = int.TryParse(Console.ReadLine(), out number);

            return number;
        }
    }
}
