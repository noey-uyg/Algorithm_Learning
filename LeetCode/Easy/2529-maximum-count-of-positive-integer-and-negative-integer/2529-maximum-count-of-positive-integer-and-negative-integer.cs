public class Solution {
    public int MaximumCount(int[] nums) {
        return Math.Max(BinarySearch(nums,0),(nums.Length - BinarySearch(nums,1)));
    }

    public int BinarySearch(int[] nums, int target){
        int left =0;
        int right = nums.Length - 1;
        int count = nums.Length;

        while(left<=right){
            int mid = (left+right)/2;

            if(nums[mid] < target){
                left = mid+1;
            }
            else{
                count = mid;
                right = mid-1;
            }
        }

        return count;
    }
}