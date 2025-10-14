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
            int T = int.Parse(Console.ReadLine());
            int MOD = 10000;
            while (T > 0)
            {
                T--;

                int[] AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int A = AB[0];
                int B = AB[1];

                bool[] visit = new bool[10001];
                int[] prev = new int[10001];
                char[] DSLR = new char[10001];

                Queue<int> q = new Queue<int>();
                q.Enqueue(A);
                visit[A] = true;

                while (q.Count > 0)
                {
                    var cur = q.Dequeue();

                    if (cur == B)
                        break;

                    int D = (cur * 2) % MOD;
                    if (!visit[D])
                    {
                        visit[D] = true;
                        prev[D] = cur;
                        DSLR[D] = 'D';
                        q.Enqueue(D);
                    }

                    int S = cur == 0 ? 9999 : cur - 1;
                    if (!visit[S])
                    {
                        visit[S] = true;
                        prev[S] = cur;
                        DSLR[S] = 'S';
                        q.Enqueue(S);
                    }

                    int L = ((cur % 1000) * 10) + (cur / 1000);
                    if (!visit[L])
                    {
                        visit[L] = true;
                        prev[L] = cur;
                        DSLR[L] = 'L';
                        q.Enqueue(L);
                    }

                    int R = ((cur % 10) * 1000) + (cur / 10);
                    if (!visit[R])
                    {
                        visit[R] = true;
                        prev[R] = cur;
                        DSLR[R] = 'R';
                        q.Enqueue(R);
                    }
                }

                string result = "";

                for (int i = B; i != A; i = prev[i])
                {
                    result = DSLR[i] + result;
                }

                Console.WriteLine(result);
            }
        }
    }
}
