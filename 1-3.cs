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
            string str;
            Console.WriteLine("Enter string: ");
            str = Console.ReadLine();
            char[] arr = new char[str.Length];
            arr = str.ToCharArray();
            for (int i = 0; i < str.Length; ++i)
            {
                if (arr[i] + 32 > 127)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
                else
                {
                    arr[i] = char.ToLower(str[i]);
                }
            }
            str = new string(arr);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}