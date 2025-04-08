using System.Collections.Generic;

public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[] {};
        List<long> result = new List<long>();
        long temp = x;
        
        while(result.Count<n){
            result.Add(temp);
            temp+=x;
        }
        
        return result.ToArray();
    }
}