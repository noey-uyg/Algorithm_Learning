using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string P = input[0];
            int K = int.Parse(input[1]);

            bool[] isPrime = new bool[K];

            for(int i = 2; i < K; i++)
            {
                isPrime[i] = true;
            }

            for(int i = 2; i * i < K; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < K; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for(int i = 2; i < K; i++)
            {
                if (isPrime[i])
                {
                    if (GetMod(P, i) == 0)
                    {
                        Console.WriteLine("BAD " + i);
                        return;
                    }
                }
            }

            Console.WriteLine("GOOD");
        }

        static int GetMod(string P, int d)
        {
            int remainder = 0;

            foreach(char c in P)
            {
                remainder = (remainder * 10 +(c - '0')) % d;
            }

            return remainder;
        }
    }
}
