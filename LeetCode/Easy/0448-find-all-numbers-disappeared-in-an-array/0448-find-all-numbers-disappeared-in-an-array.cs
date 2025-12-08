public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int[] arr = new int[nums.Length+1];
        IList<int> result = new List<int>();

        for(int i=0;i<nums.Length;i++){
            arr[nums[i]]++;
        }

        for(int i=1;i<arr.Length;i++){
            if(arr[i] == 0){
                result.Add(i);
            }
        }
        
        return result;
    }
}