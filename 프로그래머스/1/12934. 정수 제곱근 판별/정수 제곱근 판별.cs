using System;

public class Solution {
    public long solution(long n) {
        return Math.Sqrt(n)%1==0 ? (long)Math.Pow(Math.Sqrt(n)+1,2) : -1;
    }
}