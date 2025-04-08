using System;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int removeCount = 0;
        int zeroCount = 0;
        
        while(s!="1"){
            string tempS = s;
            zeroCount += tempS.Count(x => (x=='0'));
            tempS = tempS.Replace("0","");
            
            s = Convert.ToString(tempS.Length,2);
            removeCount++;
        }
        int[] answer = new int[2]{removeCount,zeroCount};
        return answer;
    }
    
}