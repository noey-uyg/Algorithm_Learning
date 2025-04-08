public class Solution {    
    public long solution(int n) {
        long[] fibo = new long[100001];
        fibo[0]=0;
        fibo[1]=1;

        for(int i=2;i<100001;i++){
            fibo[i] = (fibo[i-1]+fibo[i-2])%1234567;
        }
        
        return fibo[n];
    }
}