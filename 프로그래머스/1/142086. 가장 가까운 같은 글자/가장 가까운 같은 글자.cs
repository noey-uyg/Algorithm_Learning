using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[] {};
        Dictionary<char,int> dict = new Dictionary<char,int>();
        List<int> result = new List<int>();
        
        for(int i=0;i<s.Length;i++){
            char c = s[i];
            
            if(dict.ContainsKey(c)){
                int idx = dict[c];
                dict[c] = i;
                result.Add(i-idx);
            }
            else{
                dict[c] = i;
                result.Add(-1);
            }
        }
        
        answer = result.ToArray();
        return answer;
    }
}