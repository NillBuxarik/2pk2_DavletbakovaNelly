using System;
using System.IO;

namespace pz_14
{
    class Program
//        Дан текстовый файл f1 с произвольным содержимым.В файл f2 переписать только четные
//строки из файла f1
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\raid\1.txt", FileMode.Open, FileAccess.Read);
            FileStream file1 = new FileStream(@"C:\raid\2.txt", FileMode.Open, FileAccess.Write);
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(file1);
            string line = "";
            int i = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (i % 2 == 0) writer.WriteLine(line);
                i++;
            }
            writer.Close();
            reader.Close();

        }
    }
}