using System;

public class Solution {
    public int solution(int x, int y, int n) {
        int answer = 0;
        int[] nums = new int[y+1];
        nums[x] = 0;

        for(int i = x; i<=y;i++){
            if(i>x &&nums[i] == 0){
                nums[i]=-1;
                continue;
            }
                
            if(i+n <= y){
                int idx = i+n;
                nums[idx] = nums[idx] == 0 ? nums[i]+1 : Math.Min(nums[idx],nums[i]+1);
            }
            if(i*2 <= y){
                int idx = i*2;
                nums[idx] = nums[idx] == 0 ? nums[i]+1 : Math.Min(nums[idx],nums[i]+1);
            }
            if(i*3 <= y){
                int idx = i*3;
                nums[idx] = nums[idx] == 0 ? nums[i]+1 : Math.Min(nums[idx],nums[i]+1);
            }
        }
        
        return nums[y];
    }
}