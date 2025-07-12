using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int count = 0;
            for(int i = 1; i <= N; i++)
            {
                if (i <= 99)
                {
                    count++;
                }
                else
                {
                    int h = i / 100;
                    int t = (i / 10) % 10;
                    int n = i % 10;

                    if ((h - t) == (t - n))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
