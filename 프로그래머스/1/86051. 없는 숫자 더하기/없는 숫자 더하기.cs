using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = -1;
        
        int sum = 0;
        Array.ForEach(numbers, i=>sum+=i);
        
        return 45-sum;
    }
}