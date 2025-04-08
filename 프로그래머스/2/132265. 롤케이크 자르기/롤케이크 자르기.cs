using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] topping) {
        int answer = 0;
        var chulDict = new Dictionary<int,int>();
        var broDict = new Dictionary<int,int>();
        
        for(int i=0;i<topping.Length;i++){
            int key = topping[i];
            if(broDict.ContainsKey(key))
                broDict[key]++;
            else
                broDict[key] = 1;
        }
        
        for(int i=0;i<topping.Length;i++){
            int key = topping[i];
            if(chulDict.ContainsKey(key))
                chulDict[key]++;
            else
                chulDict[key] = 1;
            
            broDict[key]--;
            
            if(broDict[key] == 0)
                broDict.Remove(key);
            
            if(chulDict.Count == broDict.Count)
                answer++;

        }
        
        return answer;
    }
}