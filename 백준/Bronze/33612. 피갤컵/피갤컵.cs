using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int year = 2024;
        static int month = 8;

        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int A = int.Parse(str[0]);

            for (int i = 1; i < A; i++)
            {
                MonthCycle();
            }
            Console.WriteLine(year + " " + month);
        }
        
        static void MonthCycle()
        {
            month += 7;

            if(month > 12)
            {
                month -= 12;
                year++;
            }
        }
    }
}
