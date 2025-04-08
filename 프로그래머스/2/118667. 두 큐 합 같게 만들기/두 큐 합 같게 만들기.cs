using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = 0;
        var q1 = new Queue<long>();        
        var q2 = new Queue<long>();
        
        long maxNum = 0;
        long sum = 0;
        long q1Sum=0;
        long q2Sum=0;
        for(int i=0;i<queue1.Length;i++){
            long p1 = (long)queue1[i];
            long p2 = (long)queue2[i];
            
            q1.Enqueue(queue1[i]);
            q2.Enqueue(queue2[i]);
            q1Sum+=p1;
            q2Sum+=p2;
            sum += (p1+p2);
            long max = Math.Max(p1, p2);
            
            if(max > maxNum)
                maxNum=max;
        }

        long targetNum = sum/2;
        int maxCount = 300000*2;
        
        if(targetNum<maxNum || sum%2!=0)
            return -1;
        
        while(true){      
            if(answer > maxCount)
                return -1;
            
            if(targetNum == q2Sum || targetNum == q1Sum)
                break;
            
            if(q1Sum>q2Sum){
                long temp = q1.Dequeue();
                q2.Enqueue(temp);
                q1Sum-=temp;
                q2Sum+=temp;
            }
            else{
                long temp = q2.Dequeue();
                q1.Enqueue(temp);
                q1Sum+=temp;
                q2Sum-=temp;
            }
            
            answer++;
        }
        
        return answer;
    }
}