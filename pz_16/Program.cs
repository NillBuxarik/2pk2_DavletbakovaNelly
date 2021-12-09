using System;

namespace pz_16
/*Пользователь вводит целое неотрицательное число N, программа с помощью процедур
должна рассчитать и вывести площадь окружности с радиусом N, объем и площадь сфер с
радиусом N*/
{
    class Program
    {
        static void GetDan(int n)
        {
            Console.WriteLine($"Площадь окружности с радиусом {n} = {Math.PI * Math.Pow(n, 2):f2}");
            Console.WriteLine($"Площадь сферы с радиусом {n} = {4 * Math.PI * Math.Pow(n, 2):f2}");
            Console.WriteLine($"Объём сферы с радиусом {n} = {(4 / 3) * Math.PI * Math.Pow(n, 3):f2}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int n = int.Parse(Console.ReadLine());
            GetDan(n);
        }
    }
}