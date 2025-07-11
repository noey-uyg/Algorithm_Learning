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
                int n = int.Parse(Console.ReadLine());

                Dictionary<string, int> dict = new Dictionary<string, int>();

                for(int j=0; j < n; j++)
                {
                    string[] input = Console.ReadLine().Split();

                    string type = input[1];

                    if (dict.ContainsKey(type))
                        dict[type]++;
                    else
                        dict[type] = 1;
                }

                int result = 1;
                foreach(var v in dict.Values)
                {
                    result *= (v+1);
                }

                Console.WriteLine(result-1);
            }
        }
    }
}
