using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int card1 = 0;
        int card2 = 0;

        for(int i=0;i<goal.Length;i++){
            string g = goal[i];
            if(card1<cards1.Length && cards1[card1].Equals(g))
                card1++;
            else if(card2<cards2.Length && cards2[card2].Equals(g))
                card2++;
            else{
                answer="No";
                break;
            }
        }
        return answer;
    }
    
    public List<string> ArrayToList(string[] arr){
        List<string> temp = new List<string>();
        
        for(int i=0;i<arr.Length;i++){
            temp.Add(arr[i]);
        }
        
        return temp;
    }
}