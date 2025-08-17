using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();

            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            List<int>[] graph = new List<int>[n+1];
            int[] indegree = new int[n+1];

            for(int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }

            for(int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                graph[A].Add(B);
                indegree[B]++;
            }

            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                if (indegree[i] == 0)
                    q.Enqueue(i);
            }

            StringBuilder sb = new StringBuilder();

            while (q.Count > 0)
            {
                int cur = q.Dequeue();
                sb.Append($"{cur} ");

                foreach(var v in graph[cur])
                {
                    indegree[v]--;
                    if (indegree[v] == 0)
                        q.Enqueue(v);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
