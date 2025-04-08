using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] A = new int[] {1, 2, 3, 4, 5};
        int[] B = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] C = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] count = new int[3];
        for(int i=0;i<answers.Length;i++){
            count[0] += answers[i] == A[i%A.Length] ? 1 : 0;
            count[1] += answers[i] == B[i%B.Length] ? 1 : 0;
            count[2] += answers[i] == C[i%C.Length] ? 1 : 0;
        }
        
        int max = Max(count);
        
        for(int i=0;i<count.Length;i++){
            if(count[i] == max){
                answer.Add(i+1);
            }
        }
        return answer;
    }
    
    public int Max(int[] count){
        int max=0;
        for(int i=0;i<count.Length;i++){
            if(count[i]>max){
                max=count[i];
            }
        }
        return max;
    }
}