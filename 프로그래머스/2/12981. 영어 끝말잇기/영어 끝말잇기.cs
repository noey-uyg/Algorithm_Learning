using System;
using System.Collections.Generic;
class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0, 0};
        Dictionary<string,int> dict = new Dictionary<string,int>();
        dict[words[0]] = 1;
        
        for(int i=1;i<words.Length;i++){
            string prevstr = words[i-1];
            string curstr = words[i];
            
            if(prevstr[prevstr.Length-1] != curstr[0] ||dict.ContainsKey(curstr)){
                answer[0] = (i%n)+1;
                answer[1] = (i/n)+1;
                break;
            }
            
            dict[curstr] = 1;
        }
        return answer;
    }
}