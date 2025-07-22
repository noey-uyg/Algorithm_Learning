using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            HashSet<string> hs = new HashSet<string>();
            List<string> result = new List<string>();

            for (int i = 0; i < N; i++)
            {
                hs.Add(Console.ReadLine());
            }

            for(int i = 0; i < M; i++)
            {
                string input = Console.ReadLine();
                if (hs.Contains(input))
                {
                    result.Add(input);
                }
            }

            result.Sort();
            Console.WriteLine(result.Count);
            foreach(var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }
}
