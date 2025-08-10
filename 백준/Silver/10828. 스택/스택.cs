using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split();

                switch (inputs[0])
                {
                    case "push":
                        {
                            stack.Push(int.Parse(inputs[1]));
                        }
                        break;
                    case "pop":
                        {
                            int temp = -1;
                            if(stack.Count > 0)
                            {
                                temp = stack.Pop();
                            }
                            Console.WriteLine(temp);
                        }
                        break;
                    case "size":
                        {
                            Console.WriteLine(stack.Count);
                        }
                        break;
                    case "empty":
                        {
                            Console.WriteLine(stack.Count > 0 ? "0" : "1");
                        }
                        break;
                    case "top":
                        {
                            Console.WriteLine(stack.Count == 0 ? "-1" : $"{stack.Peek()}");
                        }
                        break;
                }
            }
        }
    }
}
