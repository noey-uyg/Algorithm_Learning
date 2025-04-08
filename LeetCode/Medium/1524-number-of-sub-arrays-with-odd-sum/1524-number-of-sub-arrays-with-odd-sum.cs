public class Solution {
    public int NumOfSubarrays(int[] arr) {
        int MOD = (int)Math.Pow(10,9) + 7;
        int sum = 0;
        int result = 0;
        int odd = 0;
        int even = 1;
        
        for(int i=0;i<arr.Length;i++){
            int num = arr[i];

            sum += num;

            if(sum % 2 == 0){
                even++;
                result+=odd;
            }else{
                odd++;
                result+=even;
            }

            result %= MOD;
        }

        return result;
    }
}