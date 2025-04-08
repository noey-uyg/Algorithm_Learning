using System;

public class Solution {
    public long solution(int[] weights) {
        long answer = 0;

        int[] weightProduct = new int[4001];
        int[] visit = new int[1001];
        
        for(int i=0;i<weights.Length;i++){            
            int m2 = weights[i]*2;
            int m3 = weights[i]*3;
            int m4 = weights[i]*4;
            
            answer += weightProduct[m2]++;
            answer += weightProduct[m3]++;
            answer += weightProduct[m4]++;      
            
            if(visit[weights[i]] > 0){
                answer -= visit[weights[i]]*2;
            }
            visit[weights[i]]++;
        }
        
        return answer;
    }
}