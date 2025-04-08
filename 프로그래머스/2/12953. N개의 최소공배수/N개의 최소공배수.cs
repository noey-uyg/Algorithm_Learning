using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = LCM(arr[0],arr[1]);
        
        for(int i=2;i<arr.Length;i++){
            answer = LCM(answer, arr[i]);
        }
        return answer;
    }
    
    public int LCM(int a, int b){
        return (a*b)/GCD(a,b);
    }
    
    public int GCD(int a, int b){
        int temp;
        while(b!=0){
            temp = a%b;
            a = b;
            b = temp;
        }
        return a;
    }
}