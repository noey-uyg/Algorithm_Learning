public class Solution {
    public int[] solution(int n, int m) {
        int gcd = GCD(n,m);
        int lcm = n*m/gcd;
        
        return new int[2]{gcd,lcm};
    }
    
    public int GCD(int n, int m)
    {
        if(m==0) return n;
        else return GCD(m, n%m);
    }
}