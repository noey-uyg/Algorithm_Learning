using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('-');

            int result = Sum(input[0]);

            for(int i=1;i<input.Length; i++)
            {
                result -= Sum(input[i]);
            }

            Console.WriteLine(result);
        }

        static int Sum(string inp)
        {
            string[] temp = inp.Split("+");

            int sum = 0;

            for(int i=0;i<temp.Length; i++)
            {
                sum += int.Parse(temp[i]);
            }

            return sum;
        }
    }
}
