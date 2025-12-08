public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=1;i<=nums.Length;i++) dict[i] = 0;

        for(int i=0;i<nums.Length;i++){
            dict[nums[i]]++;
        }

        foreach(var v in dict){
            if(v.Value == 2){
                result[0] = v.Key;
            }
            else if(v.Value == 0){
                result[1] = v.Key;
            }
        }

        return result;
    }
}