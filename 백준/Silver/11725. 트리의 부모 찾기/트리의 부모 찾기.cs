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
        static int[] parent;
        static bool[] visit;
        static List<int>[] tree;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            tree = new List<int>[N + 1];

            for(int i = 1; i <= N; i++)
            {
                tree[i] = new List<int>();
            }

            parent = new int[N + 1];
            visit = new bool[N + 1];

            for (int i = 0; i < N - 1; i++)
            {
                string[] input = Console.ReadLine().Split();
                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);

                tree[l].Add(r);
                tree[r].Add(l);
            }

            DFS(1);

            StringBuilder sb = new StringBuilder();

            for(int i = 2; i <= N; i++)
            {
                sb.AppendLine(parent[i].ToString());
            }

            Console.Write(sb.ToString());
        }

        static void DFS(int n)
        {
            visit[n] = true;

            foreach(var v in tree[n])
            {
                if (!visit[v])
                {
                    parent[v] = n;
                    DFS(v);
                }
            }
        }
    }
}
