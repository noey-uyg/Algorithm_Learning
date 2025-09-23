using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = int.Parse(Console.ReadLine());
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            StringBuilder sb = new StringBuilder();
            
            foreach(var v in input1)
            {
                if (dict.ContainsKey(v))
                    dict[v]++;
                else
                    dict[v] = 1;
            }

            foreach(var v in input2)
            {
                if (dict.ContainsKey(v))
                    sb.Append(dict[v] + " ");
                else
                    sb.Append("0 ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
