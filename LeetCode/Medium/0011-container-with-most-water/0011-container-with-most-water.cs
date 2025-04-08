public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxWater = (right - left) * Math.Min(height[left],height[right]);
        
        while(left < right || right > left){
            int tempMax = (right - left) * Math.Min(height[left],height[right]);

            maxWater = Math.Max(maxWater,tempMax);

            if(height[left] < height[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxWater;
    }
}