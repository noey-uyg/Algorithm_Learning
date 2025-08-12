using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for(int i = 0; i < N; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Count; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }

            nums.Sort();
            double avg = nums.Average();
            Console.WriteLine((int)Math.Round(avg));
            Console.WriteLine(nums[nums.Count / 2]);

            int maxFrequency = dict.Values.Max();
            List<int> frequency = new List<int>();
            foreach(var v in  dict)
            {
                if(maxFrequency == v.Value)
                    frequency.Add(v.Key);
            }
            frequency.Sort();
            Console.WriteLine(frequency.Count > 1 ? frequency[1] : frequency[0]);
            Console.WriteLine(nums[N - 1] - nums[0]);
        }
    }
}
