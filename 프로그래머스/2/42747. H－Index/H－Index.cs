using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        var list = new List<int>(citations);
        list.Sort();
        
        for(int i=list.Count-1;i>=0;i--){
            if(list[i] <= answer)
                break;  
            answer++;
            
        }
        return answer;
    }
}