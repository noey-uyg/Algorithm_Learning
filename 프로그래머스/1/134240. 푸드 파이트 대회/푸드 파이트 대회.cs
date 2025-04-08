using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for(int i=1;i<food.Length;i++){
            if(food[i]%2==1){
                food[i]-=1;
            }
            
            food[i]/=2;
            
            for(int j=0;j<food[i];j++){
                answer+=i.ToString();
            }
        }
        string str = new String(answer.Reverse().ToArray());
        
        return answer +"0"+ str;
    }
}