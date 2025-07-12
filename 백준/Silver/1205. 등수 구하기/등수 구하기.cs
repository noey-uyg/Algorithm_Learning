using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int N = int.Parse(str[0]);
            int score = int.Parse(str[1]);
            int P = int.Parse(str[2]);

            int[] arr = new int[N];
            if (N > 0)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    arr[i] = int.Parse(input[i]);
                }

                if(N==P && score <= arr[N - 1])
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            int rank = 1;

            for(int i = 0; i < N; i++)
            {
                if (score < arr[i])
                {
                    rank++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(rank);
        }
    }
}
