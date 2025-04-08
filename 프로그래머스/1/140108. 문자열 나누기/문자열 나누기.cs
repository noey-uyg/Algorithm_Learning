using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string str = s[0].ToString();
        char word = s[0];
        int wordCount = 1;
        int diffCount = 0;
        List<string> strList = new List<string>();
        
        if(s.Length<=1)
            strList.Add(str);
        for(int i=1;i<s.Length;i++){
            char c = s[i];
            char nextC = i+1>=s.Length ? s[s.Length-1] : s[i+1];
            
            if(word == c){
                wordCount+=1;
                str+=c;
            }
            else{
                diffCount+=1;
                str+=c;
            }
            
            if(wordCount == diffCount){
                strList.Add(str);
                str=nextC.ToString();
                word=nextC;
                wordCount=1;
                diffCount=0;
                i+=1;
            }
            
            if(i==s.Length-1){
                strList.Add(str);
                break;
            }
        }

        answer = strList.Count;
        return answer;
    }
}