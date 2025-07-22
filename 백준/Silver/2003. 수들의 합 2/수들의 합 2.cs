using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] arr = new int[n];

            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int count = 0;
            int left = 0;
            int sum = 0;

            for(int right = 0; right < n;right++)
            {
                sum += arr[right];

                while(sum > m)
                {
                    sum -= arr[left++];
                }

                if(sum == m)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
