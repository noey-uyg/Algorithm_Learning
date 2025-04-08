using System;

public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[2];
        
        long sum = 0;
        int start = 0;
        int end = 0;
        int minLeng = sequence.Length+1;
        
        while(true){
            if(sum>=k){
                if(sum==k && end-start < minLeng){
                    minLeng = end-start;
                    answer[0] = start;
                    answer[1] = end - 1;
                }
                sum -= sequence[start++];
            }else{
                if(end==sequence.Length) break;
                
                sum += sequence[end++];
            }
        }
        return answer;
    }
}