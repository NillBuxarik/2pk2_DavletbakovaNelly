using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.WriteLine("Варивнт 10");
                //Первое задание
                Console.WriteLine("Задание 1");
                {
                    int i;
                    for (i = 30; i <= 100; i += 7) Console.WriteLine(i);
                }
            //Второе задание
           
                Console.WriteLine("Задание 2");
                char a = 'L';
                {
                    for (var i1 = 0; i1 < 7; i1++) Console.WriteLine(a);
                    a++;
                }
           
            //Третье задание
            
                Console.WriteLine("Задание 3");
                var j1 = '#';
                for (int i = 0; i != 4; i++)
                {
                    for (int i1 = 0; i1 != 4; i1++)
                    {
                        Console.Write(j1);
                    }
                    Console.WriteLine();
                }
            
            //Четверое задание
           
                Console.WriteLine("Задание 4");
            for (int i = 0; i <= 100; i++)
                if (i % 13 == 0) Console.WriteLine(i);
            Console.WriteLine();
            //Пятое задание
            Console.WriteLine("Задание №5");

            for (int r = 4, t = 50; Math.Abs(r - t) != 11; r++, t--)
            {
                Console.WriteLine(" {0} {1} ", r, t);
            }
        }

    }
}
