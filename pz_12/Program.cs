using System;

namespace pz_12
{
    class Program
    {
        /* вар 10. Дан текст, состоящий из нескольких строк.Создайте на основе него двумерный
массив, в котором в строку массива записываются все слова каждого
предложения.Используйте ступенчатые двумерные массивы*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            int  i;
            string str = Console.ReadLine();
            char[] seps = {  '.', ',', '!', '?' };
            string[] parts = str.Split(seps);
            Console.WriteLine("Результат разделения строки: ");
            for (i = 0; i < parts.Length; i++)
            {
                if (parts[i].Contains(' '))
                {
                    string result = string.Join(" ", parts);
                    Console.WriteLine(result.ToLower());
                    break;
                }
            }   
        }
    }
}