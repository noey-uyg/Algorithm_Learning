using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> Score = new List<int>(score.ToList());
        
        Score.Sort();
        Score.Reverse();
        
        for(int i=0;i<Score.Count;i+=m){
            if(i+m > Score.Count)
                break;
            answer += Score[i-1+m]*m;
        }
        return answer;
    }
}