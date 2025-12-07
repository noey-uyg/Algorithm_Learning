public class Solution {
    public int CountOdds(int low, int high) {
        int N = high - low + 1;
        return N % 2 == 0 ?  N / 2 : (low % 2 == 1 || high % 2 == 1) ? N / 2 + 1 : N /2;
    }
}