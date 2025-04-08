using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    List<int> list = new List<int>();
    
    public int solution(int k, int[,] dungeons) {
        for(int i=0;i<dungeons.GetLength(0);i++){
            if(k>=dungeons[i,0]){
                DFS(k-dungeons[i,1],dungeons,new bool[dungeons.GetLength(0)],i, 1);
            }      
        }

        return list.Max();
    }
    
    public void DFS(int k, int[,] dungeons, bool[] visit, int index, int count){
        visit[index] = true;
        for(int i=0;i<dungeons.GetLength(0);i++){
            if(visit[i] || k<dungeons[i,0])
                continue;

            DFS(k-dungeons[i,1],dungeons,visit,i, count+1);
            list.Add(count+1);    
        }
        visit[index] = false;
    }
}