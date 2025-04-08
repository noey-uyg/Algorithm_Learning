using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visit = new bool[n];
        var q = new Queue<int>();
        
        for(int i=0;i<n;i++){
            if(!visit[i]){
                q.Clear();
                q.Enqueue(i);
                answer++;
                
                while(q.Count>0){
                    int cur = q.Dequeue();
                    
                    for(int j=0;j<n;j++){
                        if(visit[j])
                            continue;
                        
                        if(computers[cur,j]==1){
                            visit[j] = true;
                            q.Enqueue(j);
                        }
                    }
                }
            }
        }
        
        return answer;
    }
}