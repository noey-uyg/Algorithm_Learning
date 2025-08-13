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
        struct State
        {
            public int x;
            public int y;
            public int broken;
            public int dist;

            public State(int x, int y, int broken, int dist)
            {
                this.x = x;
                this.y = y;
                this.broken = broken;
                this.dist = dist;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] dx = new int[4] { 1, 0, -1, 0 };
            int[] dy = new int[4] { 0, 1, 0, -1 };

            int[,] map = new int[N, M];
            bool[,,] visit = new bool[N, M, 2];

            for(int i = 0; i < N; i++)
            {
                string mapInput = Console.ReadLine();
                for(int j = 0; j < M; j++)
                {
                    map[i, j] = mapInput[j] - '0';
                }
            }

            Queue<State> q = new Queue<State>();
            q.Enqueue(new State(0, 0, 0, 1));
            visit[0, 0, 0] = true;

            while(q.Count > 0)
            {
                var cur = q.Dequeue();

                if(cur.x == N-1 && cur.y == M - 1)
                {
                    Console.WriteLine(cur.dist);
                    return;
                }

                for(int i = 0; i < 4; i++)
                {
                    int nx = cur.x + dx[i];
                    int ny = cur.y + dy[i];

                    if (nx < 0 || ny < 0 || nx >= N || ny >= M)
                        continue;

                    if (map[nx,ny]==0 && !visit[nx, ny, cur.broken])
                    {
                        visit[nx, ny, cur.broken] = true;
                        q.Enqueue(new State(nx, ny, cur.broken, cur.dist + 1));
                    }
                    else if (map[nx,ny]==1 && cur.broken == 0 && !visit[nx, ny, 1])
                    {
                        visit[nx, ny, 1] = true;
                        q.Enqueue(new State(nx, ny, 1, cur.dist + 1));
                    }
                }
            }

            Console.WriteLine(-1);
        }
    }
}
