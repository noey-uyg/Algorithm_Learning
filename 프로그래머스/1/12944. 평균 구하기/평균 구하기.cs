using System;
public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int sum =0;
        Array.ForEach(arr, x=>sum+=x);
        
        return (double)sum/arr.Length;
    }
}