using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] str = Console.ReadLine().Split();
                int A = int.Parse(str[0]);
                int B = int.Parse(str[1]);

                if (A == 0 && B ==0)
                    break;

                Console.WriteLine(Sum(A,B));
            }
        }

        static int Sum(int a,int b)
        {
            return a + b;
        }

        static string IsBig(int a, int b)
        {
            return a > b ? "Yes" : "No";
        }
    }
}
