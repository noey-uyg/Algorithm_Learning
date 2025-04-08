using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string,int> rank = new Dictionary<string,int>();
        
        for(int i=0;i<players.Length;i++){
            rank[players[i]] = i;
        }
        
        foreach(var v in callings){
            rank[v] -=1;
            string ogPlayer = players[rank[v]];
            rank[ogPlayer]+=1;
            
            players[rank[ogPlayer]] = ogPlayer;
            players[rank[v]] = v;
        }
        return players;
    }
}