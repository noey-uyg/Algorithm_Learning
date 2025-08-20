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
            string[] nm = Console.ReadLine().Split();

            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[] trees = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int left = 0;
            int right = trees.Max();
            int result = 0;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                long count = 0;

                foreach(var v in trees)
                {
                    if (v > mid)
                        count += v - mid;
                }

                if (count >= M)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
