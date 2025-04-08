using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split(" ");
        
        int min = int.MaxValue;
        int max = int.MinValue;
        
        for(int i=0;i<str.Length;i++){
            int num = int.Parse(str[i]);
            
            if(num > max)
                max = num;
            if(num < min)
                min = num;
        }
        
        return $"{min} {max}";
    }
}