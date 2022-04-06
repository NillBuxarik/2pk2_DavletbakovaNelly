using System;

namespace $safeprojectname$
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number));

        }
        static int Sum(int number)
        {
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }
    }
}


