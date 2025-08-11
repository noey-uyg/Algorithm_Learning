using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                Stack<char> st = new Stack<char>();

                for(int j = 0; j < s.Length; j++)
                {
                    char c = s[j];
                    
                    if(c == '(')
                    {
                        st.Push(c);
                    }
                    else
                    {
                        if (st.Count > 0 && st.Peek() == '(')
                            st.Pop();
                        else
                            st.Push(c);
                    }
                }

                if (st.Count > 0)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}
