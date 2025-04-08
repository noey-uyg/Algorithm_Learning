public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        for(int i=1;i<nums.Length;i++){
            nums[i] = Math.Max(nums[i],nums[i]+nums[i-1]);
            max = Math.Max(nums[i],max);
        }

        return max;
    }
}