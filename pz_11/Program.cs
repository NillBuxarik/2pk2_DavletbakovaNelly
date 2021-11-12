using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] parts = str.Split(' ');
            string result = string.Join("", parts);
            Console.WriteLine(result);
            Console.WriteLine();

            char[] del = result.ToCharArray();
            char[] del1 = new char[del.Length];
            for (int i = del.Length - 1, j = 0; i >= 0; i--, j++)
            {
                del1[j] = del[i];
            }

            string str1 = new string(del);
            string str2 = new string(del1);
            if (str1 == str2)
            {
                Console.WriteLine("Палиндром");
            }
            else
                Console.WriteLine("Не палиндром");
        }
    }
}
