using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            long[,] dp = new long[2, 100001];
            int[,] sticker = new int[2, 100001];

            while (T>0)
            {
                T--;

                int n = int.Parse(Console.ReadLine());
                string[] input1 = Console.ReadLine().Split();
                string[] input2 = Console.ReadLine().Split();

                for(int i = 0; i < n; i++)
                {
                    sticker[0,i] = int.Parse(input1[i]);
                    sticker[1,i] = int.Parse(input2[i]);
                }

                dp[0, 0] = sticker[0, 0];
                dp[1, 0] = sticker[1, 0];

                if (n > 1)
                {
                    dp[0, 1] = sticker[0, 1] + dp[1, 0];
                    dp[1, 1] = sticker[1, 1] + dp[0, 0];
                }

                for(int i = 2; i < n; i++)
                {
                    dp[0, i] = sticker[0, i] + Math.Max(dp[1, i - 1], dp[1, i - 2]);
                    dp[1, i] = sticker[1, i] + Math.Max(dp[0, i - 1], dp[0, i - 2]);
                }

                Console.WriteLine(Math.Max(dp[0, n - 1], dp[1, n - 1]));
            }
        }
    }
}
