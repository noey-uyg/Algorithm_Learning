using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        var arrr = arr.Where(x=>x%divisor==0).OrderBy(x=>x).ToArray();
        return arrr.Count() > 0 ? arrr : new int[1]{-1};
    }
}