using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int min = arr.Min();
        arr = arr.Where(x=>x != min).ToArray();
        return arr.Length > 0 ? arr : new int[1]{-1};
    }
}