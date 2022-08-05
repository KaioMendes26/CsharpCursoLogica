using System;
using System.Globalization;

namespace Program
{

    class Program 
    {

        static void Main(String[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int M, N;
            Console.Write("Quantas linha vai ter na matriz?");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter na matriz?");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATEIZ DIGITADA: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }




        }
    }
}