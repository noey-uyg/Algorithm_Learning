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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ANum = numbers[0];
            int BNum = numbers[1];

            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> B = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));

            int count = 0;

            for(int i = 0; i < A.Length; i++)
            {
                if (B.Contains(A[i]))
                    count++;
            }

            Console.WriteLine((ANum - count) + (BNum - count));
        }
    }
}
