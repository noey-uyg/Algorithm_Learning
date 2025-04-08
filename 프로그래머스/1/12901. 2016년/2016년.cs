using System.Collections.Generic;
using System;

public class Solution {
    public string solution(int a, int b) {
        var month = new Dictionary<int,int>{
            {1,31},{2,29},{3,31},{4,30},{5,31},{6,30},{7,31},{8,31},{9,30},{10,31},{11,30},{12,31}
        };
        var day = new Dictionary<int,string>{
            {0,"THU"},{1,"FRI"},{2,"SAT"},{3,"SUN"},{4,"MON"},{5,"TUE"},{6,"WED"}
        };
        
        int total = 0;
        
        for(int i=1;i<a+1;i++){
            total += month[i];
        }
        total -= (month[a] - b);

        return day[total%7];
    }
}