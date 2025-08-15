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
            AbsHeap heap = new AbsHeap();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < N; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    if(heap.Count == 0)
                    {
                        sb.AppendLine("0");
                    }
                    else
                    {
                        sb.AppendLine(heap.Pop().ToString());
                    }
                }
                else
                {
                    heap.Push(input);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }

    class AbsHeap
    {
        private int[] arr;
        public int Count;

        public AbsHeap(int capacity = 100000)
        {
            arr = new int[capacity+1];
            Count = 0;
        }

        public void Push(int value)
        {
            arr[++Count] = value;
            int idx = Count;

            while (idx > 1)
            {
                int parent = idx / 2;
                if (Compare(arr[idx], arr[parent]) < 0)
                {
                    Swap(idx, parent);
                    idx = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public int Pop()
        {
            int root = arr[1];
            arr[1] = arr[Count--];
            int idx = 1;

            while (true)
            {
                int left = idx * 2;
                int right = left + 1;
                int small = idx;

                if (left <= Count && Compare(arr[left], arr[small]) < 0) small = left;
                if (right <= Count && Compare(arr[right], arr[small]) < 0) small = right;

                if(small != idx)
                {
                    Swap(idx, small);
                    idx = small;
                }
                else
                {
                    break;
                }
            }

            return root;
        }

        private int Compare(int a,int b)
        {
            int absA = Math.Abs(a);
            int absB = Math.Abs(b);
            if(absA !=  absB) return absA.CompareTo(absB);
            return a.CompareTo(b);
        }

        private void Swap(int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
