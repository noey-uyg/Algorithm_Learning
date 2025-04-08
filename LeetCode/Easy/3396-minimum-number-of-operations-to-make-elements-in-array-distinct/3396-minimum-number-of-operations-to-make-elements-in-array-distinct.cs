public class Solution {
    public int MinimumOperations(int[] nums) {
        int index = 0;
        int maxLength = nums.Length;
        int count = 0;
        HashSet<int> set = new HashSet<int>();
        while(index < maxLength){
            set.Clear();
            bool check = false;

            for(int i=index;i<maxLength;i++){
                if(set.Contains(nums[i])){
                    check = true;
                    break;
                }

                set.Add(nums[i]);
            }
            if(check){
                index+=3;
                count++;
            }
            else{
                break;
            }
        }    

        return count;    
    }
}