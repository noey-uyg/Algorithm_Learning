using System;
using System.Collections.Generic;
using System.IO;
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
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            
            int[,] map = new int[N, M];
            bool[,] visit = new bool[N, M];

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            for(int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    map[i,j] = input[j] - '0';
                }
            }

            Queue<(int,int)> q = new Queue<(int, int)>();

            q.Enqueue((0,0));
            visit[0, 0] = true;

            while(q.Count > 0)
            {
                var r = q.Dequeue();
                int x = r.Item1;
                int y = r.Item2;

                for(int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || ny < 0 || nx >= N || ny >= M)
                        continue;

                    if (map[nx, ny] == 0)
                        continue;

                    if (visit[nx, ny])
                        continue;

                    map[nx, ny] = map[x, y] + 1;
                    visit[nx, ny] = true;
                    q.Enqueue((nx, ny));
                }
            }

            Console.WriteLine(map[N - 1, M - 1]);
        }
    }
}
