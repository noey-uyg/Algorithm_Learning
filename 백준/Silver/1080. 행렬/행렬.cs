using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int[,] A;
        static int[,] B;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            A = new int[N, M];
            B = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();

                for(int j = 0; j < row.Length; j++)
                {
                    A[i, j] = row[j] - '0';
                }
            }

            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < row.Length; j++)
                {
                    B[i, j] = row[j] - '0';
                }
            }

            int count = 0;

            for(int i = 0; i <= N - 3; i++)
            {
                for(int j = 0; j <= M - 3; j++)
                {
                    if(A[i,j] != B[i, j])
                    {
                        Filp(i, j);
                        count++;
                    }
                }
            }

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    if(A[i,j] != B[i, j])
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static void Filp(int r, int c)
        {
            for(int i = r; i < r + 3; i++)
            {
                for(int j=c; j < c + 3; j++)
                {
                    A[i, j] = A[i, j] == 0 ? 1 : 0;
                }
            }
        }
    }
}
