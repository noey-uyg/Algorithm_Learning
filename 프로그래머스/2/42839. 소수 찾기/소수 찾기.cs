using System;
using System.Collections.Generic;

public class Solution {
    HashSet<string> hs = new HashSet<string>();
    HashSet<int> result = new HashSet<int>();
    
    public int solution(string numbers) {
        for(int i=0;i<numbers.Length;i++){
            string tempStr = numbers[i].ToString();
            int tempInt = int.Parse(tempStr);

            if(hs.Contains(tempStr))
                continue;
            hs.Add(tempStr);
            if(IsPrime(tempInt))
                result.Add(tempInt);
            
            DFS(numbers,tempStr, i, 0, new bool[numbers.Length]);
        }
        
        return result.Count;
    }
    
    public void DFS(string numbers, string startNum, int index, int depth, bool[] visit){
        if(depth > numbers.Length-1)
            return;
        
        visit[index] = true;
        for(int i=0;i<numbers.Length;i++){
            if(visit[i])
                continue;
            
            string tempStr = startNum+numbers[i];
            int tempInt = int.Parse(tempStr);
            
            if(hs.Contains(tempStr))
                continue;
            
            if(IsPrime(tempInt))
                result.Add(tempInt);
                
            hs.Add(tempStr); 
            DFS(numbers,tempStr,i,depth+1,visit);
        }
        visit[index] = false;
    }
    
    public bool IsPrime(int num){
        int sqrtNum =  (int)Math.Sqrt(num);
        
        if(num < 2)
            return false;
        
        for(int i = 2;i<=sqrtNum; i++){
            if(num%i == 0)
                return false;
        }
        
        return true;
    }
}