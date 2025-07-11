using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int A = int.Parse(str[0]);

            for (int i = 0; i < A; i++)
            {
                Console.WriteLine(SciCom());
            }
        }
        
        static string SciCom()
        {
            return "SciComLove";
        }
    }
}
