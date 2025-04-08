using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] order) {
        int orderIDX = 0;
        int curBox = 1;
        Stack<int> st = new Stack<int>();
        
        while(orderIDX<order.Length){
            int od = order[orderIDX];
            if(curBox<=od){
                while(curBox<=od){
                    st.Push(curBox++);
                }
                orderIDX++;
                st.Pop();
            }else{
                if(st.Count == 0 || st.Peek() != od) break;
                orderIDX++;
                st.Pop();
            }
        }
        
        return orderIDX;
    }
}