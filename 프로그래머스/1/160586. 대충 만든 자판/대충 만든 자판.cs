using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        foreach(var v in keymap){
            for(int i=0;i<v.Length;i++){
                char c = v[i];
                if(!dict.ContainsKey(c))
                    dict[c] = i+1;
                else{
                    if(dict[c] > i+1){
                        dict[c] = i+1;
                    }
                }
            }
        }
        
        int idx=0;
        foreach(var v in targets){
            int result = 0;
            
            for(int i=0;i<v.Length;i++){
                char c = v[i];
                
                if(!dict.ContainsKey(c)){
                    result = -1;
                    break;
                }
                result+=dict[c];    
            }
            answer[idx] = result;
            idx++;
        }
        return answer;
    }
}