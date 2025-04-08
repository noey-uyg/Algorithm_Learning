using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public long[] solution(long[] numbers) {
        long[] answer = new long[numbers.Length];
        string str = ConvertBinary((long)Math.Pow(10,15)).Replace("1","0").Insert(0,"1");

        List<long> binaryList = new List<long>();
        
        for(long i=BinaryToInt(str);i>=1;i>>=1){
            binaryList.Add(i);
        }

        for(int i=0;i<numbers.Length;i++){
            long num = numbers[i];
            for(int j=binaryList.Count-1;j>=0;j--){
                if((num&binaryList[j]) == 0){
                    num+=binaryList[j];
                    if(binaryList[j] != 1){
                        num-= binaryList[j+1];
                    }
                    break;
                }
            }
            answer[i] = num;
        }
        
        return answer;
    }
    
    public long BinaryToInt(string number){
        return Convert.ToInt64(number,2);
    }
    public string ConvertBinary(long number){
        return Convert.ToString(number,2);
    }
}