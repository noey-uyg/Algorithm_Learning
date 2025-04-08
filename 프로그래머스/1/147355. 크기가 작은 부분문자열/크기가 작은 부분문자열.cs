using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int pLeng = p.Length;
        for(int i=0;i<=(t.Length - pLeng);i++){
            string str = t.Substring(i, pLeng);
            if(long.Parse(str)<=long.Parse(p))
                answer++;
        }
        return answer;
    }
}