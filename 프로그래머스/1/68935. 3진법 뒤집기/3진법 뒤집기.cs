using System;
using System.Text;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        var builder = new StringBuilder();
        
        while(n>0){
            builder.Append(n%3);
            n/=3;
        }
        
        int j=0;
        for(int i=builder.Length-1;i>=0;i--){
            int num = builder[i]-'0';
            answer += num*(int)Math.Pow(3,j);
            j++;
        }
        return answer;
    }
}