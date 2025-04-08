using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string dirs) {
        int answer = 0;
        int[,,] arr = new int[11,11,4]; //[n,n,b] b => 위:0 아래:1 오른쪽:2 왼쪽:3
        int maxX = arr.GetLength(0);
        int maxY = arr.GetLength(1);
        int changeX = 5;
        int changeY = 5;
        
        for(int i=0;i<dirs.Length;i++){
            char dir = dirs[i];
            int curX = changeX;
            int curY = changeY;
            
            if(dir=='U'){
                if(changeY-1<0)
                    continue;
                changeY--;
            }
            else if(dir=='D'){
                if(changeY+1>=maxY)
                    continue;
                changeY++;
            }
            else if(dir=='R'){
                if(changeX +1 >= maxX)
                    continue;
                changeX++;
            }
            else{
                if(changeX-1 < 0)
                    continue;
                changeX--;
            }
            
            int xGap = curX - changeX;
            int yGap = curY - changeY;
            //Gap이 -면 아래, 오른 
            //Gap이 +면 왼, 위
            
            if(xGap != 0){
                if(xGap<0){
                    if(arr[curX,curY,2] == 1 || arr[changeX,changeY,3] == 1)
                        continue;
                    
                    arr[curX,curY,2] = 1;
                    arr[changeX,changeY,3] = 1;
                }
                else{
                    if(arr[curX,curY,3] == 1 || arr[changeX,changeY,2] == 1)
                        continue;
                    
                    arr[curX,curY,3] = 1;
                    arr[changeX,changeY,2] = 1;
                }
            }
            if(yGap != 0){
                if(yGap<0){
                    if(arr[curX,curY,1] == 1 || arr[changeX,changeY,0] == 1)
                        continue;
                    
                    arr[curX,curY,1] = 1;
                    arr[changeX,changeY,0] = 1;
                }
                else{
                    if(arr[curX,curY,0] == 1 || arr[changeX,changeY,1] == 1)
                        continue;
                    
                    arr[curX,curY,0] = 1;
                    arr[changeX,changeY,1] = 1;
                }        
            }
            
            answer++;
        }
        return answer;
    }
}