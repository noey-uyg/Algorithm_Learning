using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        Array.Sort(numbers);
        
        for(int i=0;i<numbers.Length-1;i++){
            for(int j=i+1;j<numbers.Length;j++){
                if(j==i) continue;
                
                list.Add(numbers[i]+numbers[j]);
            }
        }
        
        list.Sort();
        answer = list.Distinct().ToArray();
        
        return answer;
    }
    
}