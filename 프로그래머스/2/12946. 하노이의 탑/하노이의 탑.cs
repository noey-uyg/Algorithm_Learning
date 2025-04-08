using System;
using System.Collections.Generic;
/*
1
[1,3]

2
[1, 2], 

[1, 3], [2, 3]

3
[1, 3], 

[1, 2], [3, 2], 

[1, 3], [2, 1], [2, 3], [1, 3]

4
[1, 2], 

[1, 3], [2, 3], 

[1, 2], [3, 1], [3, 2], [1, 2], 

[1, 3], [2, 3], [2, 1], [3, 1], [2, 3], [1, 2], [1, 3], [2, 3]
*/

public class Solution {
    public int[,] solution(int n) {
        var list = new List<(int, int)>();
        Hanoi(n,1,3,2,list);
        int[,] answer = new int[list.Count,2];
        
        for(int i=0;i<list.Count;i++){
            answer[i,0] = list[i].Item1;
            answer[i,1] = list[i].Item2;
        }
        return answer;
    }
    
    public void Hanoi(int n, int start, int target, int remain, List<(int,int)> list){
        if(n==1){
            list.Add((start,target));
            return;
        }
        
        Hanoi(n-1, start, remain, target, list);
        list.Add((start,target));
        Hanoi(n-1, remain, target, start, list); 
    }
}