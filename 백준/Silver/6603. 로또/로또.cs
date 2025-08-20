using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int k;
        static int[] input;
        static List<int> result = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                k = input[0];
                
                if (k == 0)
                    break;

                result.Clear();

                DFS(0, 1);
                Console.WriteLine();
            }
        }

        static void DFS(int depth, int start)
        {
            if(depth == 6)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for(int i = start; i <= k; i++)
            {
                result.Add(input[i]);
                DFS(depth + 1, i + 1);
                result.RemoveAt(result.Count - 1);
            }

        }
    }
}
