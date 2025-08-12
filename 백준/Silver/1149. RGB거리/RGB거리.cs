using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] dp = new int[1001, 3];
            int[,] arr = new int[1001, 3];

            for(int i = 1; i <= N; i++)
            {
                string[] s = Console.ReadLine().Split();

                arr[i, 0] = int.Parse(s[0]);
                arr[i, 1] = int.Parse(s[1]);
                arr[i, 2] = int.Parse(s[2]);
            }

            for(int i = 0; i < 3; i++)
            {
                dp[1, i] = arr[1, i];
            }

            for(int i = 2; i <= N; i++)
            {
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + arr[i, 0];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + arr[i, 1];
                dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + arr[i, 2];
            }

            Console.WriteLine(Math.Min(Math.Min(dp[N, 0], dp[N, 1]), dp[N, 2]));
        }
    }
}
