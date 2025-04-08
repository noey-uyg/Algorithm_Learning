public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 0;

        for(int i=1;i<nums.Length;i++){
            if(nums[index] != nums[i]){
                nums[++index] = nums[i];
            }
        }

        return index+1;
    }
}