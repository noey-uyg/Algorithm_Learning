using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] T = new int[n];
            int[] P = new int[n];
            int[] dp = new int[n + 1];

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                T[i] = int.Parse(input[0]);
                P[i] = int.Parse(input[1]);
            }

            for(int i = n - 1; i >= 0; i--)
            {
                if (T[i] + i <= n)
                {
                    dp[i] = Math.Max(P[i] + dp[i + T[i]], dp[i + 1]);
                }
                else
                {
                    dp[i] = dp[i + 1];
                }
            }

            Console.WriteLine(dp[0]);
        }
    }
}
