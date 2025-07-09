using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int N;
        static int S;
        static int count;
        static int[] arr;
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            N = int.Parse(str[0]);
            S = int.Parse(str[1]);

            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            DFS(0, 0, 0);

            Console.WriteLine(count);
        }

        static void DFS(int sum, int index, int depth)
        {
            if(index == N)
            {
                if(sum == S && depth > 0)
                {
                    count++;
                }
                return;
            }

            DFS(sum+arr[index], index + 1, depth+1);
            DFS(sum, index + 1, depth);
        }
    }
}
