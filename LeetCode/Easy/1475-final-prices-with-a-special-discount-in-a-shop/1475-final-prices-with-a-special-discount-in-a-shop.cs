public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] result = new int[prices.Length];

        for(int i=0;i<prices.Length;i++){
            bool isDiscount = false;
            for(int j=i+1;j<prices.Length;j++){
                if(prices[i] >= prices[j]){
                    result[i] = prices[i] - prices[j];
                    isDiscount = true;
                    break;
                }
            }

            if(!isDiscount){
                result[i] = prices[i];
            }
        }

        return result;
    }
}