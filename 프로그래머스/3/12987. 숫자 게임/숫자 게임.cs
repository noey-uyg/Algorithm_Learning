using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        Array.Sort(A);
        Array.Sort(B);
        int aIndex = 0;
        for(int i=0;i<A.Length;i++){
            if(A[aIndex] < B[i]){
                answer++;
                aIndex++;
            }
        }
        return answer;
    }
}