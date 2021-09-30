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
                   
            int a = 30;
            int b = 100;


            for (int i = a; i <= b; i += 7)
            {
                Console.WriteLine(i);
            }
            //Второе задание
            Console.WriteLine("Задание 2");

            char gaga = 'L';
            for (var i = 0; i < 7; i++)
            {
                Console.WriteLine(gaga);
                gaga++;
            }
            //Третье задание
            Console.WriteLine("Задание 3");
            var j1 = '#';
            for (int i = 0; i != 4; i++)
            {
                for (int i0 = 0; i0 != 4; i0++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine();
            }
            //Четверое задание
            Console.WriteLine("Задание 4");
            for (int i = 1; i != 100; i++)
            {
                var david = i % 13;
                if (david == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Пятое задание
            Console.WriteLine("Задание 5");

            for (int i = 4, j = 50; i - j != 211; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
                
