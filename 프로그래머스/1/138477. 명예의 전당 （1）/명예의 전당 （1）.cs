using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        
        List<int> honor = new List<int>();
        int minValue = 0;
        
        for(int i=0;i<score.Length; i++){
            int point = score[i];
            
            honor.Add(point);
            
            if(honor.Count > k){
                minValue = honor.Min();
                honor.RemoveAt(honor.IndexOf(minValue));
            }
            
            answer[i] = honor.Min();
        }
        
        return answer;
    }
}