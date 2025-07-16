using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split();

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            bool[] remove = new bool[n+1];
            int count = 0;

            for(int i = 2; i <= n; i++)
            {
                if (remove[i])
                    continue;

                for(int j=i; j <= n; j += i)
                {
                    if (!remove[j])
                    {
                        remove[j] = true;
                        count++;

                        if (count == k)
                        {
                            Console.WriteLine(j);
                            return;
                        }

                    }
                }
            }
        }
    }
}
