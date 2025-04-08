using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        int idx=0;
        int findSkip = 0;
        for(int i=97;i<=122;i++){
            char c = (char)i;
            bool bTemp = false;
            for(int j=0; findSkip < skip.Length && j<skip.Length; j++){
                char cSkip = skip[j];
                if(cSkip.Equals(c)){
                    bTemp=true;
                    findSkip++;
                    break;
                }
            }
            if(!bTemp){
                dict[c] = idx;
                idx++;
            }
        }
        
        for(int i=0;i<s.Length;i++){
            char cS = s[i];
            
            int val = dict[cS]+index;
            answer += dict.FirstOrDefault(x => x.Value == val%dict.Count).Key;
        }
                
        return answer;
    }
}