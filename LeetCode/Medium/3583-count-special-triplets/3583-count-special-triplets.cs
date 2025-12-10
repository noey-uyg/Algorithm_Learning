public class Solution {
    public int SpecialTriplets(int[] nums) {
        int Mod = 1000000007;
        long result = 0;
        int Max = 100001 * 2;
        
        int[] left = new int[Max];
        int[] right = new int[Max];

        foreach(var v in nums){
            right[v]++;
        }

        for(int i=0;i<nums.Length;i++){
            int j = nums[i];
            right[j]--;

            int target = j*2;

            long leftCount = left[target];
            long rightCount = right[target];
            result = (result + leftCount * rightCount) % Mod;

            left[j]++;
        }

        return (int)result;
    }
}