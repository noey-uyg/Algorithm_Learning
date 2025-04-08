using System;

public class Solution {
    public int solution(int storey) {
        int answer = 0;

        while(storey > 0){
            int curNum = storey%10;
            int nextNum = (storey/10)%10;
            
            if(curNum>5){
                storey += 10;
                answer += 10 - curNum;
            }
            else if(curNum >= 5 && nextNum>=5){
                storey +=10;
                answer += 10 - curNum;
            }
            else{
                answer += curNum;
            }
            
            storey/=10;
        }
        
        return answer;
    }
}