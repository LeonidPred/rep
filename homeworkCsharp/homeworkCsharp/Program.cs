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
            ConsoleKeyInfo symbol;
            int space = 0;
            while (true)
            {
             symbol = Console.ReadKey();
                if(symbol.Key == ConsoleKey.Spacebar)
                {
                    ++space;
                }
                if (symbol.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            Console.WriteLine("\nКоличество пробелов: " + space);
            Console.ReadKey();
        }
    }
}
