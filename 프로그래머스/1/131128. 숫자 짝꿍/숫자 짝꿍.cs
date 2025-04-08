using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        var dictX = new Dictionary<char,int>(){{'0',0},{'1',0},{'2',0},{'3',0},{'4',0},{'5',0},{'6',0},{'7',0},{'8',0},{'9',0}};
        var dictY = new Dictionary<char,int>(){{'0',0},{'1',0},{'2',0},{'3',0},{'4',0},{'5',0},{'6',0},{'7',0},{'8',0},{'9',0}};
        
        int lengX = X.Length;
        int lengY = Y.Length;
        for(int i=0;i<lengX;i++){
            dictX[X[i]]+=1;
        }
        for(int i=0;i<lengY;i++){
            dictY[Y[i]]+=1;
        }
        
        var b = new StringBuilder();
        
        for(int i=9;i>=0;i--){
            char c = (char)(i+'0');
            if(dictX[c] == 0 || dictY[c]==0) continue;
            
            int temp = Math.Min(dictX[c],dictY[c]);
            
            for(int j=0;j<temp;j++){
                b.Append(i);
            }
        }
        answer = b.ToString();
        if(String.IsNullOrEmpty(answer)){
            answer = "-1";
        }
        else if(answer[0] == '0'){
            answer = "0";
        }
        
        return answer;
    }
}