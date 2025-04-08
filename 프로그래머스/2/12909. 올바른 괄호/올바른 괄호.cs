using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        Stack<char> cStack = new Stack<char>();
        
        for(int i=0;i<s.Length;i++){
            char chr = s[i];
            
            if(chr.Equals('(')){
                cStack.Push(chr);
            }else{
                if(cStack.Count == 0)
                    return false;
                
                char sChr = cStack.Peek();
                if(sChr.Equals('('))
                    cStack.Pop();
                else
                    return false;
            }
        }
        
        if(cStack.Count != 0)
            return false;
        
        return answer;
    }
}