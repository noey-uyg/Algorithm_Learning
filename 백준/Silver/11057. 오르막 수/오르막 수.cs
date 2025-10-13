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
            int[,] dp = new int[1001, 11];
            int MOD = 10007;

            for(int i = 0; i < 10; i++)
            {
                dp[1, i] = 1;
            }

            for(int i=2; i<= 1000; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    {
                        dp[i, j] = dp[i - 1, j] % MOD;
                    }
                    else
                    {
                        dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]) % MOD;
                    }
                }
            }

            int result = 0;

            for(int i = 0; i < 10; i++)
            {
                result = (result + dp[N, i]) % MOD;
            }
            
            Console.WriteLine(result);
        }
    }
}
