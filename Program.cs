using System;

namespace HexadecimalMultiplicationTable
{
    class HexadecimalMultiplicationTable // Змінено ім'я класу на відповідне ім'я вихідного файлу програми
    {
        static void Main(string[] args)
        {
            // Виведення заголовків рядків та стовпців
            Console.Write("    ");
            for (int i = 0; i <= 15; i++)
            {
                Console.Write($"{i:X}  ");
            }
            Console.WriteLine();

            // Виведення рядків таблиці множення
            for (int i = 0; i <= 15; i++)
            {
                Console.Write($"{i:X}  ");
                for (int j = 0; j <= 15; j++)
                {
                    Console.Write($"{i * j:X}  ");
                }
                Console.WriteLine();
            }
        }
    }
}

