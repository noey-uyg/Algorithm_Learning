using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int n, int[] works) {
        long answer = 0;
        Heap heap = new Heap();
        
        for(int i=0;i<works.Length;i++){
            heap.Enqueue(works[i]);    
        }
        
        for(int i=0;i<n;i++){
            if(heap.Count()==0)
                break;
            
            int num = heap.Dequeue();
            num--;
            if(num!=0){
                heap.Enqueue(num);
            }
        }
        
        return heap.Result();
    }
    
    public class Heap{
        private List<int> heap = new List<int>();
        
        public int Count(){
            return heap.Count;
        }
        
        public void Enqueue(int n){
            if(heap.Count == 0)
                heap.Add(n);
            else
            {
                int start = 0;
                int end = heap.Count - 1;
                int harf = 0;
                
                while (start != end)
                {
                    if (end - start == 1)
                    {
                        if (heap[start] > n)
                            harf = end;
                        else
                            harf = start;
                        break;
                    }
                    else
                    {
                        harf = start + ((end - start) / 2);
                        if (heap[harf] < n)
                            end = harf;
                        else
                            start = harf;
                    }
                }

                if (heap[harf] < n)
                    heap.Insert(harf, n);
                else
                    heap.Insert(harf + 1, n);
            }
        }
        
        public int Dequeue(){
            if(heap.Count>0){
                int dequeueNum = heap[0];
                heap.RemoveAt(0);
                return dequeueNum;
            }
            return -1;
        }
        
        public int Peek(){
            if(heap.Count>0){
                return heap[0];
            }
            
            return -1;
        }
        
        public long Result(){
            long sum = 0;
            for(int i=0;i<heap.Count;i++){
                sum+=heap[i]*heap[i];
            }
            
            return sum;
        }
    }
}