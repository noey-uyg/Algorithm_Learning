public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        int point = 0;
        long result = 0;
        Array.Sort(happiness);

        for(int i=happiness.Length-1;i>=0;i--){
            if(k == 0) break;
            if(happiness[i] - point <= 0) break;
            
            result += happiness[i] - point;
            k--;
            point++;
        }

        return result;
    }
}