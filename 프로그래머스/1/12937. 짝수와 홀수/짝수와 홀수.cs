using System;

public class Solution {
    public string solution(int num) {
        return Math.Abs(num)%2==1 ? "Odd":"Even";
    }
}