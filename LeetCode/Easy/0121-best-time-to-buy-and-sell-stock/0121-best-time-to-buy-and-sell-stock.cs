public class Solution {
    public int MaxProfit(int[] prices) {
        int minNum = prices[0];
        int maxNum = 0;
        int result = 0;

        for(int i=1;i<prices.Length;i++){
            if(minNum > prices[i]){
                minNum = prices[i];
                continue;
            }

            if(minNum < prices[i]){
                maxNum = prices[i];
                result = Math.Max(result, maxNum - minNum);
            }
        }

        return result;
    }
}