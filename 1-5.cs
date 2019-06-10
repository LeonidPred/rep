using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo button;
            int x = 0;
            bool cycle = true;
            Console.Write("Для ввода числа нажмите 1, для выбора случайного числа нажмите 2: ");
            while (cycle)
            {
                button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("\nВведите число: ");
                        try
                        {
                            x = int.Parse(Console.ReadLine());
                            cycle = false;
                        }
                        catch
                        {
                            Console.Write("Вы ввели не число! Введите 1 для ввода, 2 для генерации случайного числа: ");
                        }
                        break;
                    case ConsoleKey.D2:
                        Random rnd = new Random();
                        x = rnd.Next(1000, 9999);
                        Console.WriteLine($"\nСлучайное число: {x}");
                        cycle = false;
                        break;
                    default:
                        continue;
                }
            }
            int y = 0;
            for (; x > 0; x /= 10 )
            {
                y = y * 10 +  (x % 10);
            }
            Console.WriteLine($"Обратное число: {y}");
            Console.ReadKey();
        }
    }
}