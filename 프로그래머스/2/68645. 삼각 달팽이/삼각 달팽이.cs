using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        int[,] arr = new int[n,n];
        
        int curNum = 1;
        int row=0;
        int col=0;
        int fill=0;
        for(int i=n;i>0;i--){
            for(int j=i; j>0;j--){
                switch(fill){
                    case 0:
                        {
                            row++;
                            arr[row-1,col] = curNum++;
                        }
                        break;
                    case 1:
                        {
                            col++;
                            arr[row-1,col] = curNum++;
                        }
                        break;
                    case 2:
                        {
                            row--;
                            col--;
                            arr[row-1,col] = curNum++;
                        }
                        break;
                }
            }
            
            fill = (fill+1)%3;
        }

        var list = new List<int>();
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(arr[i,j] != 0){
                    list.Add(arr[i,j]);
                }
            }
        }
        return list.ToArray();
    }
}