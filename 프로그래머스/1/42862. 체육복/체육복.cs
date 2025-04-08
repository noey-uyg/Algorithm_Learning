using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i=0;i<lost.Length;i++){
                dict[lost[i]]=-1;
        }
        for(int i=0;i<reserve.Length;i++){
            if(dict.ContainsKey(reserve[i]))
                dict[reserve[i]]+=1;
            else
                dict[reserve[i]]=1;
        }
        
        for(int i=1;i<=n;i++){
            if(!dict.ContainsKey(i))
                continue;
            if(dict[i] == -1){
                if(dict.ContainsKey(i-1) && dict[i-1] == 1){
                    dict[i]+=1;
                    dict[i-1]-=1;
                }
                else if(dict.ContainsKey(i+1) && dict[i+1] == 1){
                    dict[i] +=1;
                    dict[i+1]-=1;
                }
            }
        }
        
        for(int i=1;i<=n;i++){
            if(dict.ContainsKey(i) && dict[i] == -1)
                continue;
            answer++;
        }
        return answer;
    }
}