using System;
using System.IO;

namespace pz_15
    /*Проверить файл на наличие текста. Если текста нет – вывести сообщение «file is empty», в
противном случае вывести содержимое на консоль*/
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\raid\2.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            string line1 = reader.ReadToEnd();
            reader.Close();
            if (line1 == line) Console.WriteLine("file is empty");
            else
            {
                FileStream file1 = new FileStream(@"C:\raid\2.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader1 = new StreamReader(file1);
                while ((line = reader1.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader1.Close();

            }

        }
    }
}

    