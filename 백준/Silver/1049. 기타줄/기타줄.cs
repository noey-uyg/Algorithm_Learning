using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int minPackage = int.MaxValue;
            int minEach = int.MaxValue;

            for (int i = 0; i < M; i++)
            {
                string[] brand = Console.ReadLine().Split();
                int package = int.Parse(brand[0]);
                int each = int.Parse(brand[1]);

                minPackage = Math.Min(minPackage, package);
                minEach = Math.Min(minEach, each);
            }

            int cost1 = minEach * N;
            int cost2 = ((N + 5) / 6) * minPackage;
            int cost3 = ((N / 6) * minPackage) + ((N % 6) * minEach);

            Console.WriteLine(Math.Min(cost1,Math.Min(cost2,cost3)));
        }
    }
}
