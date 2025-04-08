public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long maxNum = int.MinValue;

        for(int i=0;i<nums.Length-2;i++){
            for(int j=i+1;j<nums.Length-1;j++){
                for(int k=j+1;k<nums.Length;k++){
                    maxNum = Math.Max(maxNum,(long)(nums[i]-nums[j])*nums[k]);
                }
            }
        }
        return maxNum < 0 ? 0 : maxNum;
    }
}