using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            string[] input = Console.ReadLine().Split();

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int maxSum = arr[0];
            int curSum = arr[0];

            for(int i = 1; i < n; i++)
            {
                curSum = Math.Max(curSum + arr[i], arr[i]);
                maxSum = Math.Max(maxSum, curSum);
            }

            Console.WriteLine(maxSum);
        }
    }
}
