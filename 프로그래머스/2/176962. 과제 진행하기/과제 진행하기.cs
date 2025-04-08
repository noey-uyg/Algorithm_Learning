using System;
using System.Collections.Generic;

public class Solution {
    public class Plan{
        public string name;
        public int sT;
        public int pT;
        
        public Plan(string name, string sT, string pT){
            this.name = name;
            string[] temp = sT.Split(":");
            this.sT = int.Parse(temp[0]) * 60 + int.Parse(temp[1]);
            this.pT = int.Parse(pT);
        }
    }
    
    public string[] solution(string[,] plans) {
        string[] answer = new string[] {};
        List<String> result = new List<String>();
        List<Plan> list = new List<Plan>();
        
        for(int i=0;i<plans.GetLength(0);i++){
            list.Add(new Plan(plans[i,0],plans[i,1],plans[i,2]));
        }
        
        list.Sort(delegate(Plan a, Plan b){
            return a.sT.CompareTo(b.sT);
        });
        
        Stack<Plan> stack = new Stack<Plan>();
        int curTime = 0;
        int limitTime = 0;
        
        for(int i=0;i<list.Count;i++){
            Plan cur = list[i];
            curTime = cur.sT;
            limitTime = (i == list.Count-1) ? int.MaxValue : list[i+1].sT - cur.sT;
            
            stack.Push(cur);
            while(stack.Count>0){
                Plan recent = stack.Peek();
                
                if(limitTime >= recent.pT){
                    limitTime -= recent.pT;
                    result.Add(recent.name);
                    stack.Pop();
                }
                else{
                    recent.pT -= limitTime;
                    break;
                }
            }
        }

        return result.ToArray();
    }
}