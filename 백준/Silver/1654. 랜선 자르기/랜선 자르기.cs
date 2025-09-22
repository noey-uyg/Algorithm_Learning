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
using System.Text;
using System.Threading;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kn = Console.ReadLine().Split();
            int K = int.Parse(kn[0]);
            int N = int.Parse(kn[1]);

            int[] arr = new int[K];

            for(int i = 0; i < K; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            long start = 1;
            long end = arr.Max();

            while(start <= end)
            {
                long mid = (start + end) / 2;
                long cnt = 0;

                for(int i = 0; i < K; i++)
                {
                    cnt += arr[i] / mid;
                }

                if(cnt >= N)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            Console.WriteLine(end);
        }
    }
}
