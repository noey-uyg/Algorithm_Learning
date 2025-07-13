using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static int N, M;
        static int[] result;
        static bool[] visit;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            N = int.Parse(input[0]);
            M = int.Parse(input[1]);

            result = new int[M];
            visit = new bool[N + 1];
            DFS(0);
            Console.Write(sb.ToString());
        }

        static void DFS(int n)
        {
            if (n == M)
            {
                for (int i = 0; i < M; i++)
                {
                    sb.Append(result[i] + " ");
                }
                sb.AppendLine();
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                if (!visit[i])
                {
                    visit[i] = true;
                    result[n] = i;
                    DFS(n + 1);
                    visit[i] = false;
                }
            }
        }
    }
}
