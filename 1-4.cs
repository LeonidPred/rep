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
            Random rnd = new Random();
            int A = rnd.Next(0, 8);
            int B = rnd.Next(A + 1, 10);
            for (int i = A; i < B; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}