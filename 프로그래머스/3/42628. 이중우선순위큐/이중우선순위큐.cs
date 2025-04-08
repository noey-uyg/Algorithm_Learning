using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] operations) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        
        for(int i=0;i<operations.Length;i++){
            if(operations[i] == "D 1"){
                if(list.Count>0)
                    list.RemoveAt(list.Count-1);
            }
            else if(operations[i] == "D -1"){
                if(list.Count>0)
                    list.RemoveAt(0);
            }
            else{
                int num = int.Parse(operations[i].Split(" ")[1]);
                list.Add(num);
                list.Sort();
            }
        }
        
        return list.Count > 0 ? new int[2]{list[list.Count-1], list[0]} : new int[2]{0,0};
    }
}