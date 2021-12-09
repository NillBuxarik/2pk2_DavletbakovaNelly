using System;

namespace pz_17
{ 
    /*Реализуйте метод, принимающий в качестве параметра целое число n и возвращающий
массив размерности [n,n], заполненный по правилу: элементы главной и побочной диагонали
= ‘*’, пересечение диагоналей = ‘o’, остальные элементы заполнены пробелами.*/
    class Program
    {
        static char[,] GetDan(int n)
        {
            char[,] A = new char[n, n];
            if (n % 2 != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = ' ';
                        if (i == j || i == n - j - 1)
                        {
                            A[i, j] = '*';
                        }
                        if (i == j && i == n / 2)
                        {
                            A[i, j] = 'o';
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = ' ';
                        if (i == j || i == n - j - 1)
                        {
                            A[i, j] = '*';
                        }
                        if (i == j && (i == n / 2 - 1 || i == n / 2) || i == n - j - 1 && (i == n / 2 - 1 || i == n / 2))
                        {
                            A[i, j] = 'o';
                        }
                    }
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int n = int.Parse(Console.ReadLine());
            char[,] A = new char[n, n];
            A = GetDan(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}