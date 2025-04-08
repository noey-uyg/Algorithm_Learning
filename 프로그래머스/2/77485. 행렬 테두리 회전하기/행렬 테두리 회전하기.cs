using System;

public class Solution {
    public int[] solution(int rows, int columns, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int[,] map = new int[101,101];
        int curNum = 1;
        
        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                map[i,j] = curNum++;
            }
        }
        
        for(int k=0;k<queries.GetLength(0);k++){
            int[,] checkMap = (int[,])map.Clone();
            int y1 = queries[k,0]-1;
            int x1 = queries[k,1]-1;
            int y2 = queries[k,2]-1;
            int x2 = queries[k,3]-1;
            
            int countX = x2-x1;
            int countY = y2-y1;
            
            int min = map[y1,x1];
            
            //→
            for(int i=countX;i>0;i--){
                int changeX = x1+i;
                map[y1,changeX] = checkMap[y1,changeX-1];
                min = Math.Min(min, map[y1,changeX]);
            }
            //↓
            for(int i=0;i<countY;i++){
                int changeY = y1+i;
                map[changeY+1,x2] = checkMap[changeY,x2];
                min = Math.Min(min, map[changeY+1,x2]);
            }
            //←
            for(int i=0;i<countX;i++){
                int changeX = x2-i;
                map[y2,changeX-1] = checkMap[y2,changeX];
                min = Math.Min(min, map[y2,changeX-1]);
            }
            //↑
            for(int i=countY;i>0;i--){
                int changeY = y2-i;
                map[changeY,x1] = checkMap[changeY+1,x1];
                min = Math.Min(min, map[changeY,x1]);
            }
            
            answer[k] = min;
        }
        
        return answer;
    }
}