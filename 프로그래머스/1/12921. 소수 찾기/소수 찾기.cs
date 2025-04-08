using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        return Enumerable.Range(0,n+1).Where(x => isPrime(x)).Count();
    }
    
    public bool isPrime(int n){
        if(n < 2)
            return false;
        int sqrt = (int)Math.Sqrt(n);
        for(int i=2;i<=sqrt;i++){
            if(n%i==0)
                return false;
        }
        return true;
    }
}