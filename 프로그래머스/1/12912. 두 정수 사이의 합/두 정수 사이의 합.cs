using System;
using System.Linq;
using System.Numerics;

public class Solution {
    public long solution(int a, int b) {
        return Enumerable.Range(Math.Min(a,b),Math.Max(a,b)-Math.Min(a,b)+1).Select(x=>(long)x).Sum();
    }
}