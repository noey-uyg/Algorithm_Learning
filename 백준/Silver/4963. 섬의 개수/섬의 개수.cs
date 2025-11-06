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
        static int[] dx = { 1, 1, 0, -1, -1, -1, 0, 1 };
        static int[] dy = { 0, 1, 1, 1, 0, -1, -1, -1 };

        static void Main(string[] args)
        {
            while (true)
            {
                int[] wh = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int w = wh[0];
                int h = wh[1];
                int count = 0;

                if (w == 0 && h == 0) break;

                int[,] arr = new int[51, 51];
                bool[,] map = new bool[51, 51];

                for (int i = 0; i < h; i++)
                {
                    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    for(int j=0;j<input.Length;j++)
                    {
                        arr[i, j] = input[j];
                    }
                }

                for (int i = 0; i < h; i++)
                {
                    for(int j = 0; j < w; j++)
                    {
                        if (arr[i, j] == 0 || map[i, j]) continue;

                        Queue<(int, int)> q = new Queue<(int, int)>();
                        q.Enqueue((i, j));
                        map[i, j] = true;

                        count++;

                        while(q.Count > 0)
                        {
                            var cur = q.Dequeue();
                            int x = cur.Item2;
                            int y = cur.Item1;

                            for(int k = 0; k < 8; k++)
                            {
                                int nx = x + dx[k];
                                int ny = y + dy[k];

                                if (nx < 0 || ny < 0 || nx >= w || ny >= h) continue;
                                if (arr[ny,nx] == 0 || map[ny, nx]) continue;

                                q.Enqueue((ny, nx));
                                map[ny, nx] = true;
                            }
                        }
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
