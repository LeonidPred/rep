using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkCsharp
{
    class Program
    {
        //функция, возвращающая сумму значений каждого элемента строки
        static ushort numeric(string x)
        {
            ushort tmp = 0;
            foreach (char c in x)
            {
                tmp += c;
            }
            return tmp;
        }
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Введите номер билета: ");
            number = Console.ReadLine();
            //проверка на шестизначность
            if (number.Length != 6)
            {
                Console.WriteLine("Номер не шестизначный!");
                Console.ReadKey();
                return;
            }
            //проверка на отсутствие нечисловых символов
            foreach (char s in number)
            {
                if (s < 48 || s >= 58)
                {
                    Console.WriteLine("Номер не числовой!");
                    Console.ReadKey();
                    return;
                }
            }
            if (numeric(number.Substring(0, 3)) == numeric(number.Substring(3, 3)))
            {
                Console.WriteLine("Номер счастливый!");
            }
            else
            {
                Console.WriteLine("Номер не счастливый!");
            }
            Console.ReadKey();
        }
    }
}