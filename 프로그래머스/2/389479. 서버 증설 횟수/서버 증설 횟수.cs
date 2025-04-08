using System;

public class Solution {
    public int solution(int[] players, int m, int k) {
        int[] hour = new int[24];
        int totalCount =0;
        
        for(int i=0;i<players.Length;i++){
            if(players[i] < m)
                continue;
            
            int curCount = hour[i];
            int needCount = players[i]/m;
            if(needCount <= curCount)
                continue;
            
            int addCount = needCount - curCount;
            for(int j=i;j<i+k && j<players.Length;j++){
                hour[j] += addCount;
            }
            
            totalCount+=addCount;
        }
        
        return totalCount;
    }
}