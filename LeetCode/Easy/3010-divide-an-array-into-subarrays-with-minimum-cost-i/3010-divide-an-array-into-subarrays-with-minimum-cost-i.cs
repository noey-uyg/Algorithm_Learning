public class Solution {
    public int MinimumCost(int[] nums) {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        for(int i=1;i<nums.Length;i++){
            if(nums[i]<min1){
                min2 = min1;
                min1 = nums[i];
            }
            else if(nums[i]<min2){
                min2 = nums[i];
            }
        }

        return nums[0]+min1+min2;
    }
}