using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину отрезка A ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите длину отрезка B ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            while ((a - b) >= 0)
            {
                a -= b;
                c +=1;
            }
            Console.WriteLine($"Колличество отрезков B ={c} ");
            Console.ReadKey();
        }
    }
}
