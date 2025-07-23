using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 5 == 0) {
                Console.WriteLine(N / 5);
            }
            else
            {
                int count = 0;
                while (N > 0)
                {
                    N -= 3;
                    count++;

                    if (N % 5 == 0)
                    {
                        count += N / 5;
                        break;
                    }
                    else if(N == 1 || N == 2)
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
