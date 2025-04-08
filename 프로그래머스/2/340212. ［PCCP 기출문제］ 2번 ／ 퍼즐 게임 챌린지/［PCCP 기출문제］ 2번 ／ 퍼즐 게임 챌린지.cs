using System;

public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int answer = 0;
        long left = 1;
        long right = limit;
        long mid = 1;
        
        while(left<right){
            mid = (left+right)/2;
            
            if(Possible(diffs,times,mid,limit)){
                left = mid+1;
            }else{
                right = mid;
            }
        }
        return (int)left;
    }
    
    public bool Possible(int[] diffs, int[] times, long mid, long limit){
        long clearTime=(long)times[0];
        
        for(int i=1;i<diffs.Length;i++){
            if(diffs[i] > mid){
                clearTime += (times[i-1] + times[i]) * (diffs[i]-mid);
            }
            clearTime += times[i];
        }
        
        return limit < clearTime;
    }
}