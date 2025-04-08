using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        List<int> progressList = new List<int>(progresses);
        List<int> speedList = new List<int>(speeds);
        List<int> result = new List<int>();
        while(progressList.Count>0){
            for(int i=0;i<progressList.Count;i++){
                progressList[i]+=speedList[i];
            }
            
            int count = 0;
            for(int i=0;i<progressList.Count;i++){
                if(progressList[i] < 100)
                    break;
                count++;
            }
            
            if(count!=0){
                progressList.RemoveRange(0,count);
                speedList.RemoveRange(0,count);
                result.Add(count);
            }
        }
        return result.ToArray();
    }
}