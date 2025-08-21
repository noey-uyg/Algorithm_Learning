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
        static void Main(string[] args)
        {
            Priority q = new Priority();
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());
            

            while(N > 0)
            {
                N--;
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    sb.AppendLine(q.Pop().ToString());
                }
                else
                {
                    q.Push(input);
                }
            }

            Console.WriteLine(sb.ToString());
        }

        class Priority
        {
            static List<int> arr = new List<int>(100001);
            static int Count => arr.Count;

            public void Push(int value)
            {
                arr.Add(value);
                int cur = arr.Count - 1;

                while(cur > 0)
                {
                    int par = (cur - 1) / 2;
                    if (arr[par] < arr[cur])
                    {
                        Swap(par, cur);
                        cur = par;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public int Pop()
            {
                if (Count == 0) return 0;

                int max = arr[0];

                arr[0] = arr[Count - 1];
                arr.RemoveAt(Count - 1);

                int cur = 0;

                while (true)
                {
                    int left = cur * 2 + 1;
                    int right = cur * 2 + 2;
                    int large = cur;

                    if(left < Count && arr[left] > arr[large])
                        large = left;
                    if(right < Count && arr[right] > arr[large])
                        large = right;

                    if(large != cur)
                    {
                        Swap(cur, large);
                        cur = large;
                    }
                    else
                    {
                        break;
                    }
                }

                return max;
            }

            private void Swap(int a, int b)
            {
                int temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
            }
        }
    }
}
