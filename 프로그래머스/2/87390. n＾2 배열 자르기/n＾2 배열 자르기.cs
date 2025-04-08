using System;
//        [0,0] [0,1] *[0,2]      [1] [2] *[3] 
//        [1,0] [1,1] *[1,2]      [2] [2] *[3] 
//        [2,0] [2,1] [2,2]      [3] [3] [3]

public class Solution {
    public long[] solution(int n, long left, long right) {
        long[] answer = new long[right - left + 1];
        long idx = 0;
        
        for(long i=left; i<=right;i++)
            answer[idx++] = Math.Max(i/n,i%n)+1;
        
        return answer;
    }
}