using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int zero=0;
        int lotto=0;
        
        for(int i=0;i<lottos.Length;i++){
            if(lottos[i]==0){
                zero++;
                continue;
            }
                
            for(int j=0;j<win_nums.Length;j++){
                if(lottos[i] == win_nums[j]){
                    lotto++;
                    break;
                }
            }
        }
        
        if(lotto==6){
            answer[0]=1;
            answer[1]=1;
        }else{
            answer[0] = 7 - (lotto+zero) >= 7 ? 6 : 7 - (lotto+zero);
            answer[1] = (7 - lotto) >= 7 ? 6 : (7 - lotto);
        }
        return answer;
    }
}