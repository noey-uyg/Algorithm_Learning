using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int count = 0;
            int result = 0;
            for(int i = 1; i < M - 1;)
            {
                if (input[i - 1] == 'I' && input[i] == 'O' && input[i + 1] == 'I')
                {
                    count++;
                    if(count == N)
                    {
                        result++;
                        count--;
                    }
                    i += 2;
                }
                else
                {
                    count = 0;
                    i++;
                }
            }

            Console.WriteLine(result);
        }

    }
}
