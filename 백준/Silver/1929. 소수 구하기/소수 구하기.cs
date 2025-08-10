using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int M = int.Parse(input[0]);
            int N = int.Parse(input[1]);

            bool[] isPrime = new bool[N + 1];

            for(int i = 2; i <= N; i++)
            {
                isPrime[i] = true;
            }

            for(int i = 2; i * i <= N; i++)
            {
                if (isPrime[i])
                {
                    for(int j = i * i; j <= N; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            for(int i = M; i <= N; i++)
            {
                if (isPrime[i])
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
