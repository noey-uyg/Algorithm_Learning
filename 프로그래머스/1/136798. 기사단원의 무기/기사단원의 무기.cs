using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i=1;i<=number;i++){
            int p = 0;
            for(int j=1;j<=Math.Sqrt(i);j++){
                if(i%j == 0){
                    p+=2;
                }
                if(j*j==i){
                    p-=1;
                }
            }
            p = p>limit ? power : p;
            answer+=p;
        }
        return answer;
    }
}