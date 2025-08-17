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
        static int n;
        static int m;
        static int v;
        static bool[] dfsCheck = new bool[1001];
        static bool[] bfsCheck = new bool[1001];
        static bool[,] tree = new bool[1001, 1001];

        static void Main(string[] args)
        {
            string[] nmv = Console.ReadLine().Split();
            n = int.Parse(nmv[0]);
            m = int.Parse(nmv[1]);
            v = int.Parse(nmv[2]);

            for(int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();

                tree[int.Parse(input[0]), int.Parse(input[1])] = true;
                tree[int.Parse(input[1]), int.Parse(input[0])] = true;
            }

            DFS(v);
            Console.WriteLine();
            BFS();
        }

        static void DFS(int vv)
        {
            Stack<int> st = new Stack<int>();

            Console.Write($"{vv} ");
            st.Push(vv);
            dfsCheck[vv] = true;

            for(int i = 1; i <= n; i++)
            {
                if (dfsCheck[i] || !tree[vv, i])
                    continue;

                DFS(i);
            }
        }

        static void BFS()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(v);
            bfsCheck[v] = true;
            
            while(q.Count > 0)
            {
                var front = q.Dequeue();

                Console.Write($"{front} ");
                
                for(int i = 1; i <= n; i++)
                {
                    if (bfsCheck[i] || !tree[front, i])
                        continue;

                    q.Enqueue(i);
                    bfsCheck[i] = true;
                }
            }
        }
    }
}
