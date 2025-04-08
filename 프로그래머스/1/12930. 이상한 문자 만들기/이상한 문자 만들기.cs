using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        return string.Join(" ",s.Split(" ").Select(word => 
               new string(word.Select((x,index) => 
              index % 2 == 0 ? char.ToUpper(x) : char.ToLower(x)).ToArray())
              ));
    }
}