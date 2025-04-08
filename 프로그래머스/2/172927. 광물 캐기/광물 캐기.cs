using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> list = new List<int>();
    
    public int solution(int[] picks, string[] minerals) {
        int answer = 0;
        
        Mine(picks,minerals,0,0);
        
        return list.Min();
    }
    
    public void Mine(int[] picks, string[] minerals, int index, int fatigue){
        if(index >= minerals.Length)
            list.Add(fatigue);

        bool isPick = false;
        
        for(int k=0;k < picks.Length;k++){
            if(picks[k] == 0)
                continue;
            isPick = true;
            
            int curFatigue = 0;
            
            for(int i=index; i<index+5;i++){
                if(i >= minerals.Length)
                    break;
                
                if(k==0){
                    curFatigue += Dig(minerals[i],1,1,1);
                }
                else if(k==1){
                    curFatigue += Dig(minerals[i],5,1,1);
                }
                else{
                    curFatigue += Dig(minerals[i],25,5,1);
                }
            }
            
            picks[k]--;
            Mine(picks,minerals,index+5,fatigue+curFatigue);
            picks[k]++;
        }
        
        if(!isPick)
            list.Add(fatigue);
    }
    
    public int Dig(string mineral, int dia, int iron, int stone){
        if(mineral == "diamond")
            return dia;
        else if(mineral == "iron")
            return iron;
        else
            return stone;
    }
}