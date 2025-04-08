using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        var list = ConvertNum(n,k);
        
        for(int i=0;i<list.Count;i++){
            if(isPrime(list[i]))
                answer++;
        }
        return answer;
    }
    
    public List<long> ConvertNum(int n, int k){
        var sb = new StringBuilder();
        while(n>0){
            int temp = n%k;
            n/=k;
            sb.Append(temp);
        }
        
        return DeleteZeroAndReverse(sb);
    }
    
    public List<long> DeleteZeroAndReverse(StringBuilder sb){
        var tempList = new List<long>();
        var tempStr = new StringBuilder();
        
        for(int i=sb.Length-1;i>=0;i--){
            if(sb[i].Equals('0')){
                if(tempStr.Length>0){
                    tempList.Add(Int64.Parse(tempStr.ToString()));
                    tempStr.Clear();    
                }
                continue;
            }
            tempStr.Append(sb[i]);
        }
        
        if(tempStr.Length>0)
            tempList.Add(Int64.Parse(tempStr.ToString()));
        
        return tempList;
    }
    public bool isPrime(long num){
        if(num==1) return false;
        
        for(int i=2;i<=(int)Math.Sqrt(num);i++){
            if(num%i==0) return false;    
        }
        
        return true;
    }
}