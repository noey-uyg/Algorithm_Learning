using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            string A = str[0];
            string B = str[1];

            int minDiff = int.MaxValue;

            for(int i = 0; i <= B.Length - A.Length; i++)
            {
                int diff = 0;

                for(int j = 0; j < A.Length; j++)
                {
                    if (A[j] != B[i + j])
                    {
                        diff++;
                    }
                }

                minDiff = Math.Min(minDiff, diff);
            }

            Console.WriteLine(minDiff);
        }
    }
}
