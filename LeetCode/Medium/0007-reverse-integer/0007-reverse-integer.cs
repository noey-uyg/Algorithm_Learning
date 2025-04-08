public class Solution {
    public int Reverse(int x) {
        int result = 0;
            
        while(x != 0){
            if(int.MinValue/10 > result || int.MaxValue/10 < result){
                return 0;
            }
            int remain = x%10;
            result = result * 10 + remain;
            x = x/10;
        }   
        

        return result;
    }
}