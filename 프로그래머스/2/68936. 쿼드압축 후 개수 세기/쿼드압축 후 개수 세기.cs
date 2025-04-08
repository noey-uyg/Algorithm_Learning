using System;
using System.Collections.Generic;

public class Solution {
    int[] answer = new int[2];
    
    public int[] solution(int[,] arr) {
        DFS(arr,0,0,arr.GetLength(0));
        return answer;
    }
    
    public void DFS(int[,] arr, int x, int y, int leng){
        bool zero = false;
        bool one = false;
        int halfLeng = leng/2;
        
        for(int i=x;i<x+leng;i++){
            for(int j=y;j<y+leng;j++){
                if(arr[i,j] == 0)
                    zero = true;
                else
                    one = true;
            }
        }
        
        if(zero != one){
            if(zero){
                answer[0]++;
                return;
            }
            else{
                answer[1]++;
                return;
            }
        }
        DFS(arr,x,y,halfLeng);
        DFS(arr,x,y+halfLeng,halfLeng);
        DFS(arr,x+halfLeng,y,halfLeng);
        DFS(arr,x+halfLeng,y+halfLeng,halfLeng);
    }
}