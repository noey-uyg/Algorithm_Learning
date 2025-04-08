using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        List<int> list = new List<int>(array);
        
        for(int i=0;i<commands.GetLength(0);i++){
            int startIdx = commands[i,0]-1;
            int endIdx = commands[i,1];
            int findIdx = commands[i,2]-1;
            
            int[] newArray = list.GetRange(startIdx, endIdx-startIdx).ToArray();
            Array.Sort(newArray);
            answer[i] = newArray[findIdx];
        }
        return answer;
    }
}