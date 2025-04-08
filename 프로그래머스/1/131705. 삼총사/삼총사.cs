using System;

public class Solution {
    int answer = 0;
    public int solution(int[] number) {
        
        int[] comb = new int[3];
        Combination(number, comb, 3, 0, 0);
        return answer;
    }
    
    public void Combination(int[] array, int[] comb, int r, int index, int depth)
    {
        if (r == 0)
        {
            int sum=0;
            Array.ForEach(comb, i=>sum+=i);
            if(sum==0)
                answer++;
        }
        else if (depth == array.Length)
        {
            return;
        }
        else
        {
            comb[index] = array[depth];

            Combination(array, comb, r - 1, index + 1, depth + 1);
            Combination(array, comb, r, index, depth + 1);
        }
    }
}