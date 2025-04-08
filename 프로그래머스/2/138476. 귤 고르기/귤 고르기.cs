using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Dictionary<int,int> tempDict = new Dictionary<int,int>();
        
        for(int i=0;i<tangerine.Length;i++){
            if(tempDict.ContainsKey(tangerine[i])){
                tempDict[tangerine[i]]++;
            }
            else
                tempDict[tangerine[i]] = 1;    
        }
        
        var dict = tempDict.OrderByDescending(x => x.Value);
        int sum =0;
        
        foreach(var v in dict){
            sum+=v.Value;
            answer++;
            if(sum>=k)
                break;
        }

        return answer;
    }
}