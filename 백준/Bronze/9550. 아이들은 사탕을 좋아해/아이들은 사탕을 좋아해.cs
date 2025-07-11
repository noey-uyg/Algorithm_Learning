using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < T; i++)
            {
                string[] inputNK = Console.ReadLine().Split();
                int N = int.Parse(inputNK[0]);
                int K = int.Parse(inputNK[1]);

                string[] candyCnt = Console.ReadLine().Split();

                int total = 0;

                for (int j = 0; j < N; j++)
                {
                    total += int.Parse(candyCnt[j]) / K;
                }

                Console.WriteLine(total);
            }
        }
    }
}
