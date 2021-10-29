using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int[,] A = new int[3, 4];
            int[] miaso = new int[3];
            Console.WriteLine("Массив А: ");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    A[i, j] = i + 4 * j + 1;
                    Console.Write(A[i, j] + " ");
                    if (i == 0)
                    {
                        sum += A[0, j];
                        miaso[0] = sum;
                    }

                    if (i == 1)
                    {
                        sum1 += A[1, j];
                        miaso[1] = sum1;
                    }

                    if (i == 2)
                    {
                        sum2 += A[2, j];
                        miaso[2] = sum2;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Наибольшая сумма: ");
            if (sum > sum1 && sum > sum2)
                Console.WriteLine(sum + " - В первой строке");
            if (sum1 > sum && sum1 > sum2)
                Console.WriteLine(sum1 + " - Во второй строке");
            if (sum2 > sum1 && sum2 > sum)
                Console.WriteLine(sum2 + " - В третьей строке");
        }
    }
}
