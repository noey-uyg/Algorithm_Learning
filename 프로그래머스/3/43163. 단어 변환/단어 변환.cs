using System;

public class Solution {
    public int solution(string begin, string target, string[] words) {
        int answer = 51;
        var visit = new bool[words.Length];
        
        if(!Array.Exists(words, x=>x == target))
            return 0;
        
        DFS(begin,target,words,visit,0,ref answer);
        
        return answer;
    }
    
    public void DFS(string begin, string target, string[] words, bool[] visit, int count, ref int answer){
        if(begin==target){
            if(count < answer){
                answer = count;
                return;
            }
        }
        
        for(int i=0;i<words.Length;i++){
            if(visit[i])
                continue;
            
            string temp = words[i];
            int checkCount = 0;
            for(int j=0; j<temp.Length;j++){
                if(begin[j]!=temp[j])
                    checkCount++;
            }
            
            if(checkCount > 1)
                continue;
            
            visit[i] = true;
            DFS(words[i],target,words,visit,count+1,ref answer);
            visit[i] = false;
        }
    }
}