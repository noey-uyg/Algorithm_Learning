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
        static int k;
        static List<int> result = new List<int>();
        static int[] input;
        static StringBuilder sb = new StringBuilder();
        
        static void Main(string[] args)
        {
            while (true)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (input[0] == 0) break;

                k = input[0];

                sb.Clear();
                result.Clear();

                DFS(0, 1);
                Console.Write(sb.ToString());
                Console.WriteLine();
            }
        }

        static void DFS(int depth, int start)
        {
            if(depth == 6)
            {
                sb.AppendLine(string.Join(" ", result));
                return;
            }

            for(int i=start; i <= k; i++)
            {
                result.Add(input[i]);
                DFS(depth + 1, i + 1);
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
