using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        
        //현재 날짜 일 수로 변경
        string[] todayArr = today.Split('.');
        int curDay = (int.Parse(todayArr[0])*12*28)+(int.Parse(todayArr[1])*28)+int.Parse(todayArr[2]);
        
        //유효기간 일 수로 변경
        Dictionary<string,int> termsDict = new Dictionary<string,int>();
        for(int i=0;i<terms.Length;i++){
            string[] termsArr = terms[i].Split(' ');
            termsDict[termsArr[0]] = int.Parse(termsArr[1])*28;
        }
        
        //파기 날짜 계산
        for(int i=0;i<privacies.Length;i++){
            string[] privacie = privacies[i].Split(' ');
            string[] priArr = privacie[0].Split('.');
            int AuthDay = (int.Parse(priArr[0])*12*28)+(int.Parse(priArr[1])*28)+int.Parse(priArr[2]);
            
            int temp = AuthDay + termsDict[privacie[1]]; 
            
            if(curDay>=temp)
                answer.Add(i+1);
        }
        
        return answer;
    }
}