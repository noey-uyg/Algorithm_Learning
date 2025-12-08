public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        IList<string> result = new List<string>();

        int targetIndex = 0;

        for(int i=1;i<=n;i++){
            if(targetIndex >= target.Length) break;

            if(i == target[targetIndex]){
                result.Add("Push");
                targetIndex++;
            }
            else{
                result.Add("Push");
                result.Add("Pop");
            }
        }

        return result;
    }
}