using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(int[] numbers) {
        var answer = new StringBuilder();
        var list = new List<string>();
        for(int i=0;i<numbers.Length;i++){
            list.Add(numbers[i].ToString());
        }
        
        list.Sort(delegate(string a, string b){
            string a1 = a+b;
            string b1 = b+a;
            
            return b1.CompareTo(a1);
        });
        
        for(int i=0;i<list.Count;i++){
            answer.Append(list[i]);
        }
        return answer[0].Equals('0') ? "0" : answer.ToString();
    }
}