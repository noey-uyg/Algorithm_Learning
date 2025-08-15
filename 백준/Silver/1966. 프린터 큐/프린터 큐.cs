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
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            while (N > 0)
            {
                N--;

                string[] input = Console.ReadLine().Split();
                int doc = int.Parse(input[0]);
                int idx = int.Parse(input[1]);
                int count = 0;

                Queue<int> q = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

                while (true)
                {
                    int max = q.Max();
                    int front = q.Dequeue();
                    idx -= 1;

                    if (front == max)
                    {
                        count++;

                        if (idx < 0)
                        {
                            Console.WriteLine(count);
                            break;
                        }
                    }
                    else
                    {
                        q.Enqueue(front);
                        if (idx < 0)
                            idx = q.Count - 1;
                    }
                }
            }
        }
    }
}
