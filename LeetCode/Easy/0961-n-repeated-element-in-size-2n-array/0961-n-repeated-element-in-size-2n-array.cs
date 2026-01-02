public class Solution {
    public int RepeatedNTimes(int[] nums) {
        List<int> temp = new List<int>();

        for(int i=0;i<nums.Length;i++){
            if(temp.Contains(nums[i])){
                return nums[i];
            }
            temp.Add(nums[i]);
        }

        return 0;
    }
}