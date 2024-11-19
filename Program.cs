using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_10n2
{
    class Program
    {
        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        static double f(int a,int b)
        {
            return a>b?a:b;
        }
        /// <summary>
        /// Вычисление функции
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = input("Введите 1 число: ");
            int b = input("Введите 2 число: ");
            Console.WriteLine($"{f(a,b)}");
            Console.Read();
        }
    }
}
