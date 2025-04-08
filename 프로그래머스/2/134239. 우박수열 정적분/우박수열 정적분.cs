using System;
using System.Collections.Generic;

public class Solution {
    public double[] solution(int k, int[,] ranges) {
        double[] answer = new double[ranges.GetLength(0)];
        var list = new List<double>();
        list.Add(k);
        
        while(k>1){
            if(k%2==0)
                k/=2;
            else
                k = (k*3)+1;
            
            list.Add(k);
        }
        
        double[] arr = new double[list.Count-1];
        
        for(int i=0;i<list.Count-1;i++){
            arr[i] = (list[i]+list[i+1])/2;
        }
        
        for(int i=0;i<ranges.GetLength(0);i++){
            double sum = 0;
            int start = ranges[i,0];
            int end = list.Count + ranges[i,1] - 1;
            
            if(start > end){
                answer[i] = -1;
                continue;       
            }
            
            for(int j = start; j < end; j++){
                sum+=arr[j];
            }
            answer[i] = sum;
        }
        
        return answer;
    }
}