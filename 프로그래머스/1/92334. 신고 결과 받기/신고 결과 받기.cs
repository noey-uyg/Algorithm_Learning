using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        var CountA = new Dictionary<string, int>();
        var CountB = new Dictionary<string, Dictionary<string,int>>();
        
        for(int i=0;i<id_list.Length;i++){
            CountA[id_list[i]] = 0;    
            CountB[id_list[i]] = new Dictionary<string,int>();
            for(int j=0;j<id_list.Length;j++){
                if(j == i)
                    continue;
                CountB[id_list[i]].Add(id_list[j],0);
            }
        }
        
        for(int i=0;i<report.Length;i++){
            string[] str = report[i].Split(" ");
            
            if(CountB[str[0]][str[1]]>0)
                continue;
            
            CountB[str[0]][str[1]] = 1;
            CountA[str[1]]+=1;
        }
        
        for(int i=0;i<id_list.Length;i++){
            for(int j=0;j<id_list.Length;j++){
                if(i==j || CountA[id_list[j]]<k || CountB[id_list[i]][id_list[j]]==0) continue;
                
                answer[i]+=1;
            }
        }
        return answer;
    }
}