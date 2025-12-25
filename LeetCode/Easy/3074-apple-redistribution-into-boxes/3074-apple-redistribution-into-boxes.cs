public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        int total = apple.Sum();
        int result = 0;
        Array.Sort(capacity);

        for(int i=capacity.Length-1;i>=0;i--){
            if(total <= 0) break;
            total -= capacity[i];
            result++;
        }
        return result;       
    }
}