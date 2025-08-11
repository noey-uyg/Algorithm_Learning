using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            int[,] dp = new int[41, 2];

            dp[0, 0] = 1;
            dp[0, 1] = 0;
            dp[1, 0] = 0;
            dp[1, 1] = 1;
            for(int i = 2; i < 41; i++)
            {
                dp[i, 0] = dp[i - 2, 0] + dp[i - 1, 0];
                dp[i, 1] = dp[i - 2, 1] + dp[i - 1, 1];
            }

            for(int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine($"{dp[N, 0]} {dp[N, 1]}");
            }
        }
    }
}
