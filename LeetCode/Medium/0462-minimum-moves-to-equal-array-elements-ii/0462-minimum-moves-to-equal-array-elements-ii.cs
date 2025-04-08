public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);

        int m = nums[nums.Length/2];
        int r = 0;

        for(int i=0;i<nums.Length;i++){
            r += Math.Abs(m - nums[i]);
        }

        return r;
    }
}