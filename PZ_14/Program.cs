using System;
using System.IO;

namespace PZ_14
   /* Дан текстовый файл f1 с произвольным содержимым.В файл f2 переписать только четные
строки из файла f1 */
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try 
            { 
                StreamWriter f1 = new StreamWriter("C:\\f1.txt");
                //"Считываем строки из файла F1"
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                //закрываем файл
                sr.Close();
                Console.ReadLine();
                // 
                // записываем их в массив
                

                //for (i = 1; length(st); st1:= st[i] + st1;
                //"Записываем в файл f2"
            
            }
        }    
    }
}
