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
        static int MAX = 100001;
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            if (n == k)
            {
                Console.WriteLine(0);
                return;
            }

            int[] dp = new int[MAX];

            Queue<int> q = new Queue<int>();
            q.Enqueue(n);            

            while (dp[k] == 0)
            {
                int front = q.Dequeue();

                if (front - 1 >= 0 && dp[front - 1] == 0)
                {
                    dp[front - 1] = dp[front] + 1;
                    q.Enqueue(front - 1);
                }
                if (front + 1 < MAX && dp[front + 1] == 0)
                {
                    dp[front + 1] = dp[front] + 1;
                    q.Enqueue(front + 1);
                }
                if (front * 2 < MAX && dp[front * 2] == 0)
                {
                    dp[front * 2] = dp[front] + 1;
                    q.Enqueue(front * 2);
                }
            }

            Console.WriteLine(dp[k]);
        }
    }
}
