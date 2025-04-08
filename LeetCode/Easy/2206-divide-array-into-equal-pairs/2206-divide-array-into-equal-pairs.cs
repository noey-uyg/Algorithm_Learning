public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],1);
                continue;
            }
            dict[nums[i]]++;
        }

        foreach(var v in dict.Values){
            if(v%2 != 0){
                return false;
            }
        }

        return true;
    }
}