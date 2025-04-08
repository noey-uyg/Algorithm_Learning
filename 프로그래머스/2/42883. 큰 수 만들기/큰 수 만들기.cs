using System;
using System.Text;

public class Solution {
    public string solution(string number, int k) {
        string answer = "";
        var sb = new StringBuilder();
        int max = 0;
        int maxIndex = 0;
        
        for(int i=0;i<k;i++){
            int curNum = int.Parse(number[i].ToString());
            if(max < curNum){
                max = curNum;
                maxIndex=i;
            }
        }
        
        sb.Append(number.Substring(maxIndex));
        k-=maxIndex;
        
        int index=0;
        while(k>0){
            if(index+1 == sb.Length){
                sb.Remove(index,1);
                k--;
                index--;
                break;
            }
            if(sb[index] < sb[index+1]){
                sb.Remove(index,1);
                k--;
                index--;
                continue;
            }
            index++;
        }
        
        return sb.ToString();
    }
}