using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        s = s.ToLower();
        
        for(int i=0;i<s.Length;i++){
            char c = s[i];
            
            if(i == 0 || s[i-1]==' '){
                c = char.ToUpper(c);
            }
            answer+= c;
        }
        return answer;
    }
}