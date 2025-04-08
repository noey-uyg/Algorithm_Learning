using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        return long.Parse(new string(n.ToString().OrderByDescending(x=>x).ToArray()));
    }
}