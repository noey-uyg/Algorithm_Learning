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
            var sr = new StreamReader(Console.OpenStandardInput());
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var sb = new StringBuilder();

            int N = int.Parse(sr.ReadLine());
            int[] A = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            int M = int.Parse(sr.ReadLine());
            int[] B = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            HashSet<int> set = new HashSet<int>(A);

            foreach(var v in B)
            {
                sb.AppendLine(set.Contains(v) ? "1" : "0");
            }

            sw.Write(sb.ToString());
            sw.Flush();
        }
    }
}
