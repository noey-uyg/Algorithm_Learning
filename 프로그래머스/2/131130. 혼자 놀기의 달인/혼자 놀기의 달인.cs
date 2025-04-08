using System;

public class Solution {
    public int solution(int[] cards) {
        int answer = 0;
        
        for(int i=0;i<cards.Length;i++){
            bool[] visit = new bool[cards.Length];
            
            int firBox = DFS(visit, i, cards);
            if(firBox == cards.Length)
                continue;
            
            for(int j=0;j<cards.Length;j++){
                if(visit[j])
                    continue;
                
                int secBox = DFS(visit,j,cards);

                answer = Math.Max(answer, firBox*secBox);
            }
        }
        return answer;
    }
    
    public int DFS(bool[] visit, int index, int[] cards){
        int cur = cards[index];
        int count = 0;
        
        while(!visit[cur-1]){
            visit[cur-1] = true;
            cur = cards[cur-1];
            count++;
        }
        
        return count;
    }
}