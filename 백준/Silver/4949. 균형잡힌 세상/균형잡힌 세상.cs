using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == ".")
                    break;

                Stack<Char> st = new Stack<Char>();
                bool isBreak = false;

                foreach(var c in input)
                {
                    if(c == '(' || c == '[')
                    {
                        st.Push(c);
                    }
                    else if(c == ')')
                    {
                        if (st.Count == 0  || st.Peek() != '(')
                        {
                            isBreak = true;
                            break;
                        }
                        st.Pop();
                    }
                    else if(c == ']')
                    {
                        if(st.Count == 0 || st.Peek() != '[')
                        {
                            isBreak = true;
                            break;
                        }
                        st.Pop();
                    }
                }
                if (st.Count > 0) isBreak = true;

                if(isBreak)
                {
                    sb.AppendLine("no");
                }
                else
                {
                    sb.AppendLine("yes");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
