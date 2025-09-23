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
        static long[] dp = new long[10001];
        static int[] arr = new int[10001];

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            dp[1] = arr[1];
            dp[2] = arr[1] + arr[2];
            dp[3] = Math.Max(dp[2], Math.Max(arr[1] + arr[3], arr[2] + arr[3]));

            for(int i = 4; i<= n; i++)
            {
                long case1 = dp[i - 1];
                long case2 = arr[i] + dp[i - 2];
                long case3 = arr[i] + arr[i - 1] + dp[i - 3];

                dp[i] = Math.Max(case1, Math.Max(case2, case3));
            }

            Console.WriteLine(dp[n]);
        }
    }
}
