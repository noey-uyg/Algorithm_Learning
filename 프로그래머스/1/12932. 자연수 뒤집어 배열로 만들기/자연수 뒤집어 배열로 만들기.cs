using System.Linq;

public class Solution {
    public int[] solution(long n) {
        return n.ToString().Reverse().Select(x=>x-'0').ToArray();
    }
}