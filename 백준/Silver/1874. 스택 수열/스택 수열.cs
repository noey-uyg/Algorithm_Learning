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
            
            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            int cur = 1;
            for(int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                while(cur <= num)
                {
                    stack.Push(cur);
                    cur++;
                    sb.AppendLine("+");
                }

                if (stack.Peek() == num)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
