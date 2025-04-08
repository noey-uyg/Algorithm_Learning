using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2] {0, 0};
        
        int sum = brown+yellow;
        
        // 왜 됐지
        for(int i=3; i<=sum/2;i++){
            if(sum%i==0){
                if((sum/i-2)*(i-2) == yellow){
                    answer[0] = sum/i;
                    answer[1] = i;
                    break;                    
                }

            }
        }
        
        return answer;
    }
}