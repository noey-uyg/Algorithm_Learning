using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        
        Array.Fill(answer,-1);
        
        Stack<int> st = new Stack<int>();
        
        for(int i=numbers.Length-1;i>=0;i--){
            while(st.Count>0){
                if(numbers[i]<st.Peek()){
                    answer[i] = st.Peek();
                    break;
                }
                st.Pop();
            }
            st.Push(numbers[i]);
        }
        
        return answer;
    }
}