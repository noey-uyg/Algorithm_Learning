public class Solution {
    public int CountPartitions(int[] nums) {
        int total = nums.Sum();
        int sum = 0;
        int count = 0;

        for(int i=0;i<nums.Length-1;i++){
            sum += nums[i];

            if((sum - (total - sum)) % 2 == 0){
                count++;
            }
        }

        return count;
    }
}