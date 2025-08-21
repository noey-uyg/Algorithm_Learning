using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] arr = new int[N + 1, N + 1];

            for(int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for(int j=0;j< input.Length; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            for (int i = N - 2; i >= 0; i--)
            {
                for(int j = 0; j <= i; j++)
                {
                    arr[i, j] += Math.Max(arr[i + 1, j], arr[i + 1, j + 1]);
                }
            }

            Console.WriteLine(arr[0, 0]);
        }

    }
}
