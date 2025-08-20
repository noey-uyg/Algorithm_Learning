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
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            int[] dx = new int[4] { 1, 0, -1, 0 };
            int[] dy = new int[4] { 0, 1, 0, -1 };

            Queue<(int, int)> q = new Queue<(int, int)>();

            while (T > 0)
            {
                T--;
                int[,] map = new int[51, 51];
                bool[,] check = new bool[51, 51];

                string[] temp = Console.ReadLine().Split();
                int M = int.Parse(temp[0]);
                int N = int.Parse(temp[1]);
                int K = int.Parse(temp[2]);
                int count = 0;

                for (int i = 0; i < K; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    int x = int.Parse(input[0]);
                    int y = int.Parse(input[1]);

                    map[y, x] = 1;
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (map[i, j] == 1 && !check[i, j])
                        {
                            q.Enqueue((i, j));
                            check[i, j] = true;

                            count++;
                            while(q.Count > 0)
                            {
                                var cur = q.Dequeue();
                                int x = cur.Item2;
                                int y = cur.Item1;

                                for(int z = 0; z < 4; z++)
                                {
                                    int nx = x + dx[z];
                                    int ny = y + dy[z];

                                    if (nx < 0 || ny < 0 || nx >= M || ny >= N)
                                        continue;

                                    if (map[ny, nx] == 0 || check[ny, nx])
                                        continue;

                                    q.Enqueue((ny, nx));
                                    check[ny, nx] = true;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine(count);
            }

        }
    }
}
