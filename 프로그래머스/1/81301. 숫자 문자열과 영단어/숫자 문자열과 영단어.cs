using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>(){{"zero",0}, {"one",1}, {"two",2},{"three",3}, {"four",4}, {"five",5}, {"six",6}, {"seven",7}, {"eight",8}, {"nine",9}};        
        
        foreach(var v in dict){
            s = s.Replace(v.Key,v.Value.ToString());
        }

        return int.Parse(s);
    }
}