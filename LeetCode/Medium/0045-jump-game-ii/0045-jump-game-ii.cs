public class Solution {
    public int Jump(int[] nums) {
        int jump = 0;
        int high = 0;
        int cur = 0;

        for(int i=0;i<nums.Length-1;i++){
            high = Math.Max(high, nums[i]+i);

            if(i == cur){
                cur = high;
                jump++;
            }
        }

        return jump;
    }
}