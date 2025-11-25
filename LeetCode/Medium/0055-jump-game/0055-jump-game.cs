public class Solution {
    public bool CanJump(int[] nums) {
        int high = 0;
        int cur = 0;

        for(int i=0;i<nums.Length-1;i++){
            high = Math.Max(high, i+nums[i]);
        }

        if(high == nums.Length-1){
            return true;
        }


        return false;
    }
}