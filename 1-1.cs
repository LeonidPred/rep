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
            char symbol;
            int space = 0;
            while (true)
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol == ' ')
                {
                    ++space;
                }
                if (symbol == '.')
                {
                    break;
                }
            }
            Console.WriteLine("\nКоличество пробелов: " + space);
            Console.ReadKey();
        }
    }
}