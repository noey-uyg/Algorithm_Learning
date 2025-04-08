using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        int w = 0;
        int h = 0;

        for(int i=0;i<sizes.GetLength(0);i++){
            int maxTemp = Math.Max(sizes[i,0], sizes[i,1]);
            int minTemp = Math.Min(sizes[i,0], sizes[i,1]);
            
            sizes[i,0] = maxTemp;
            sizes[i,1] = minTemp;
            
            w = Math.Max(sizes[i,0], w);
            h = Math.Max(sizes[i,1], h);
        }
        return w*h;
    }
}