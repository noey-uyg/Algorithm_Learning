using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        List<string> discounts = new List<string>(discount);
        int maxLength = discount.Length - 10;

        for(int i=0;i<=maxLength;i++){
            List<string> tempList = discounts.GetRange(i,10);
            bool auth = false;
            for(int j=0;j<want.Length;j++){
                if(number[j] == tempList.Count(x=>(x==want[j])))
                    auth = true;
                else{
                    auth = false;
                    break;
                }
            }
            
            if(auth)
                answer++;
        }
        return answer;
    }
}