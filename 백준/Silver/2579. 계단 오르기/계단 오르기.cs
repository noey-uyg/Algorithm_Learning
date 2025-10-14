using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
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
            int[,] dp = new int[301, 2];
            int[] num = new int[301];

            for(int i = 1; i <= N; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            dp[1, 0] = num[1];
            dp[1, 1] = 0;
            dp[2, 0] = num[2];
            dp[2, 1] = num[1] + num[2];

            for(int i = 3; i <= N; i++)
            {
                // 이전 게단을 밟지 않았을 때
                dp[i, 0] = Math.Max(dp[i - 2, 0], dp[i - 2, 1]) + num[i];
                // 이전 계단을 밟을 때
                dp[i, 1] = num[i] + dp[i - 1, 0];
            }

            Console.WriteLine(Math.Max(dp[N, 0], dp[N, 1]));
        }
    }
}
