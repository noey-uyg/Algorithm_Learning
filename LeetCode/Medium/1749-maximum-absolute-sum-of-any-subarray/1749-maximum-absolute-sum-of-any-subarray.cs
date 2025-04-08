public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int maxSum = 0;
        int minSum = 0;
        int tempMax = 0;
        int tempMin = 0;

        for(int i=0;i<nums.Length;i++){
            tempMax = Math.Max(tempMax + nums[i], nums[i]);
            tempMin = Math.Min(tempMin + nums[i], nums[i]);

            maxSum = Math.Max(maxSum, tempMax);
            minSum = Math.Min(minSum, tempMin);
        }

        maxSum = maxSum < 0 ? maxSum * -1 : maxSum;
        minSum = minSum < 0 ? minSum * -1 : minSum;

        return Math.Max(maxSum, minSum);
    }
}