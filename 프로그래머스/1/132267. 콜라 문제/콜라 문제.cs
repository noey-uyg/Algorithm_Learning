using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;

        while(n>=a){
            int temp = n%a;
            int temp1 = n/a;
            temp1*=b;
            n= temp+temp1;
            answer+=temp1;
        }
        return answer;
    }
}