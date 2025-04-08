public class Solution {
    public bool IsPalindrome(int x) {
        int result = 0;
        int temp = x;

        while(temp>0){
            int remain = temp%10;
            result = result * 10 + remain;
            temp/=10;
        }

        return result == x;
    }
}