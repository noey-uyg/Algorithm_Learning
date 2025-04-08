using System;

public class Solution {
    public string solution(string s) {
        int mid = s.Length/2;
        return s.Length % 2 ==0 ? s.Substring(mid-1,2) : s[mid].ToString();
    }
}