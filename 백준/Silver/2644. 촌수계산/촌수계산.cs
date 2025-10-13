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
            int[] calcNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = int.Parse(Console.ReadLine());

            int A = calcNum[0];
            int B = calcNum[1];


            List<int>[] graph = new List<int>[N + 1];

            for(int i = 1; i <= N; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i = 0; i < M; i++)
            {
                int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = xy[0];
                int y = xy[1];

                graph[x].Add(y);
                graph[y].Add(x);
            }

            bool[] visited = new bool[N + 1];
            int[] dist = new int[N + 1];

            for (int i = 1; i <= N; i++)
            {
                dist[i] = -1;
            }

            Queue<int> q = new Queue<int>();
            visited[A] = true;
            dist[A] = 0;
            q.Enqueue(A);

            while (q.Count > 0)
            {
                int cur = q.Dequeue();

                foreach (var v in graph[cur])
                {
                    if (!visited[v])
                    {
                        visited[v] = true;
                        dist[v] = dist[cur] + 1;
                        q.Enqueue(v);
                    }
                }
            }

            Console.WriteLine(dist[B]);
        }
    }
}
