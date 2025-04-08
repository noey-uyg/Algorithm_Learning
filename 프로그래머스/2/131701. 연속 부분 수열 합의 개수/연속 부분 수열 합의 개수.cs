using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        List<int> list = new List<int>(elements);
        int maxLength = elements.Length;
        for(int i=0;i<maxLength;i++){
            list.Add(elements[i]);
        }
        
        int sum = 0;
        Array.ForEach(elements, x => sum+=x);
        Dictionary<int,int> sumDict = new Dictionary<int, int>();
        sumDict[sum] = 0;
        
        for(int i=0;i<maxLength;i++){
            sum=0;
            for(int j=1;j<maxLength;j++){
                List<int> temp = list.GetRange(i,j);
                sum = temp.Sum();
                sumDict[sum] = 0;
            }
        }
        
        return sumDict.Count;
    }
}