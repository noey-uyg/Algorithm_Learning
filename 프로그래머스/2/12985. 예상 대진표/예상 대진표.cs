using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        while(true){
            answer++;
            
            int max = Math.Max(a,b);
            int min = Math.Min(a,b);
            
            if(max-1 == min){
                if(max%2==0)
                    break;
            }
            
            if(a%2==0)
                a=a/2;
            else
                a=(a+1)/2;
            
            if(b%2==0)
                b=b/2;
            else
                b=(b+1)/2;
        }

        return answer;
    }
}