using System;
using System.Collections.Generic;

public class Solution {
    public class Process{
        public int location;
        public int priorities;
        
        public Process(int location, int priorities){
            this.location = location;
            this.priorities = priorities;
        }
    }
    
    public int solution(int[] priorities, int location) {
        int answer = 0;
        Queue<Process> process = new Queue<Process>();
        
        for(int i=0;i<priorities.Length;i++){
            Process temp = new Process(i, priorities[i]);
            process.Enqueue(temp);
        }
        
        while(process.Count>0){
            Process cur = process.Dequeue();
            bool exe = true;
            
            var temp = process.ToArray();
            for(int i=0;i<temp.Length;i++){
                if(temp[i].priorities > cur.priorities){
                    process.Enqueue(cur);
                    exe = false;
                    break;
                }
            }
            
            if(exe){
                answer++;
                if(location == cur.location){
                    break;
                }
            }
        }       

        return answer;
    }
}