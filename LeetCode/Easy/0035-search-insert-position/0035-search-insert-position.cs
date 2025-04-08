public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int result = -1;

        for(int i=0;i<nums.Length;i++){
            if(target < nums[i] || target == nums[i]){
                result = i;
                break;
            }
        }

        if(result == -1){
            return nums.Length;
        }

        return result;
    }
}