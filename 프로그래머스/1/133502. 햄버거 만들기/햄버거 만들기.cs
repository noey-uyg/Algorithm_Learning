using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredients) {
        int answer = 0;
        List<int> stk = new List<int>();   
        
        for(int i=0;i<ingredients.Length;i++){
            int ingredient = ingredients[i];
            stk.Add(ingredient);
            
            if(stk.Count>=4 && (stk[stk.Count-4]==1 
               && stk[stk.Count-3]==2 && stk[stk.Count-2]==3 && stk[stk.Count-1]==1)){
                answer++;
                stk.RemoveAt(stk.Count-4);
                stk.RemoveAt(stk.Count-3);
                stk.RemoveAt(stk.Count-2);
                stk.RemoveAt(stk.Count-1);
            }
        }
        return answer;
    }
}