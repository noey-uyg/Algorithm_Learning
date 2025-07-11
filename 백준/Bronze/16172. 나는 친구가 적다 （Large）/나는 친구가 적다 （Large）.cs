using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string find = Console.ReadLine();

            StringBuilder filter = new StringBuilder();

            foreach(var c in input)
            {
                if (char.IsLetter(c))
                    filter.Append(c);
            }

            if (filter.ToString().Contains(find))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
