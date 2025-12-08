public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len*2];
        
        for(int i=0;i<len*2;i++){
            result[i] = nums[i%len];
        }

        return result;
    }
}