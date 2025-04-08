using System;
using System.Collections.Generic;

public class Solution {  
    public class Target{
        public int s;
        public int e;

        public Target(int s, int e){
            this.s = s;
            this.e = e;
            }
    }
    
    public int solution(int[,] targets) {
        int answer = 0;
        
        List<Target> list = new List<Target>();
        
        for(int i=0;i<targets.GetLength(0);i++){
            Target target = new Target(targets[i,0], targets[i,1]);
            list.Add(target);
        }
        
        list.Sort(delegate(Target a, Target b){
            return a.e.CompareTo(b.e);
        });
        
        int targetE = 0;
        for(int i=0;i<list.Count;i++){
            if(list[i].s>=targetE){
                answer++;
                targetE = list[i].e;
                Console.WriteLine($"{list[i].s}, {list[i].e}");
            }            
        }
        
        return answer;
    }
}