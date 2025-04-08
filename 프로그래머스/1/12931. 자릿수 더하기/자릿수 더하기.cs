using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        var str = n.ToString();
        return str.Select(x=>x -'0').Sum();
    }
}