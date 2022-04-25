using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace PZ_2_10_events
{
    class Programm
    {
        static void Main()
        {// генерация значений и запись в массив Array.Add
            ArrayList Array = new ArrayList();

            for (int i = 0, k = 8; i < 8; i++)
            {
                Array.Add(new Train("name" + i.ToString(), k, DateTime.Now));
                k--;
            }
            //вывод сгенерированных значений 
            foreach (Train c in Array)
            {
                Console.WriteLine(c.ToString());
            }
            string str;
            bool b = true;
            int count = 0;
            while (b)
            {
                Console.WriteLine("\n\nВведите номер поезда для поиска");
                str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]) && (Convert.ToInt32(str[i]) <= 8 || Convert.ToInt32(str[i]) >= 0)) count++;
                }

                if (count == str.Length)
                {
                    foreach (Train c in Array)
                    {
                        if (str == c.number.ToString()) Console.WriteLine(c.ToString());
                    }
                    b = false;
                }
                else Console.WriteLine("Повторите попытку");
            }

            Console.ReadLine();
        }
    }
}
