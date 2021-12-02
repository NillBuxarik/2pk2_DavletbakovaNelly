using System;
using System.Linq;

namespace pz_18
{
    class Program
    {
        ////Задание 1
        //static int ri(int a1, int d, int n)
        //{

        //    if (n < 0) { Console.WriteLine("Ошибка"); return 0; }
        //    if (n == 0) { Console.WriteLine(0); return 0; }
        //    if (n == 1) { Console.WriteLine(a1); return a1; }
        //    else { a1 = a1 + d; n = n - 1; return ri(a1, d, n); }

        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Задание №1:");
        //    int n = Convert.ToInt16(Console.ReadLine());
        //    ri(45, 7, n);
        //    ri(50, 3, n);
        //}
        //Задание 1
        static int ri(int a1, int d, int n)
        {

            if (n < 0) { Console.WriteLine("Ошибка"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(a1); return a1; }
            else { a1 = a1 * d; n = n - 1; return ri(a1, d, n); }

        }

        static void Main(string[] args)
        {
            Console.Write("Задание №1:");
            int n = Convert.ToInt16(Console.ReadLine());
            ri(10, 0.6, n);
            ri(8, 4, n);
        }
    }
}
