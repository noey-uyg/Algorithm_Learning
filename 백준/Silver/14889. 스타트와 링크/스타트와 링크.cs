using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static int N;
        static int[,] S;
        static bool[] selected;
        static int min = int.MaxValue;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            S = new int[N, N];
            selected = new bool[N];

            for(int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j=0;j< input.Length; j++)
                {
                    S[i, j] = int.Parse(input[j]);
                }
            }

            DFS(0, 0);
            Console.WriteLine(min);
        }

        static void DFS(int index, int count)
        {
            if(count == N / 2)
            {
                MinUpdate();
                return;
            }

            for(int i=index; i < N; i++)
            {
                selected[i] = true;
                DFS(i + 1, count + 1);
                selected[i] = false;
            }
        }

        static void MinUpdate()
        {
            int start = 0;
            int link = 0;

            for(int i = 0; i < N; i++)
            {
                for(int j = i + 1; j < N; j++)
                {
                    if (selected[i] && selected[j])
                    {
                        start += S[i, j] + S[j, i];
                    }
                    else if (!selected[i] && !selected[j])
                    {
                        link += S[i, j] + S[j, i];
                    }
                }
            }

            int diff = Math.Abs(start - link);
            if (diff < min)
                min = diff;
        }
    }
}
