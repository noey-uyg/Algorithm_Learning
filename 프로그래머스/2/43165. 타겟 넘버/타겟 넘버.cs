using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        Target(numbers,target,0,0,ref answer);
        return answer;
    }
    
    public void Target(int[] numbers, int target, int index, int sum, ref int answer){
        if(numbers.Length == index){
            if(sum == target){
                answer++;
            }
        }
        else{
            Target(numbers,target,index+1,sum+numbers[index],ref answer);
            Target(numbers,target,index+1,sum-numbers[index],ref answer);
            
        }
    }
}