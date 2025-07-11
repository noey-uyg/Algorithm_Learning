using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string A = Console.ReadLine();
                string B = Console.ReadLine();

                int len = A.Length;
                int count = 0;

                for (int j = 0; j < len; j++)
                {
                    if (A[j] != B[j])
                        count++;
                }

                Console.WriteLine($"Hamming distance is {count}.");
            }
        }
    }
}
