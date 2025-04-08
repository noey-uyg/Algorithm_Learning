using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        List<string> temp = new List<string>(){"aya", "ye", "woo", "ma"};
        List<string> temp1 = new List<string>(){"ayaaya", "yeye", "woowoo", "mama"};
        
        for(int i=0;i<babbling.Length;i++){
            for(int j=0;j<temp.Count;j++){
                babbling[i] = babbling[i].Replace(temp1[j],"X");   
                babbling[i] = babbling[i].Replace(temp[j],"O");
            }
        }
        
        for(int i=0;i<babbling.Length;i++){
            string str = babbling[i];
            bool result = false;
            for(int j=0;j<str.Length;j++){
                if(str[j]!='O'){
                    result=true;
                    break;
                }
            }
            if(!result)
                answer++;
        }
        return answer;
    }
}