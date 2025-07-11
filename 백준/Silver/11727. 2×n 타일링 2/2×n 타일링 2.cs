using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[Math.Max(3, n+1)];

            arr[1] = 1;
            arr[2] = 3;

            for(int i = 3; i <= n; i++)
            {
                arr[i] = (arr[i - 1] + 2 * arr[i - 2]) % 10007;
            }

            Console.WriteLine(arr[n]);
        }
    }
}
