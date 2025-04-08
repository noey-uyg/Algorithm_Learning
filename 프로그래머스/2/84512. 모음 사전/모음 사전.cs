using System;
using System.Collections.Generic;

public class Solution {
    static Dictionary<char, int> words = new Dictionary<char, int>(){{'A',1},{'E',2},{'I',3},{'O',4},{'U',5}};
    
    public class Alpha{
        public char chr;
        public int index;
        public int maxLeng;
        public Dictionary<int, int> point = new Dictionary<int, int>();
        
        public Alpha(char chr, int index, int maxLeng){
            this.chr = chr;
            this.index = index;
            this.maxLeng = maxLeng;
        }
        
        public void Calc(){
            for(int i=0;i<words.Count;i++){
                if(maxLeng-i == maxLeng){
                    point[maxLeng] = words[chr];
                    continue;
                }                    
                point[maxLeng-i] = ((int)Math.Pow(maxLeng,i)*index) + point[maxLeng-i+1];
            }
        }
    }
    
    public int solution(string word) {
        int answer = 0;
        
        int maxLeng = words.Count;
        Dictionary<char, Alpha> dict = new Dictionary<char, Alpha>();
        
        foreach(var v in words){
            Alpha a = new Alpha(v.Key,v.Value-1,words.Count);
            a.Calc();
            dict[v.Key] = a;
        }

        for(int i=0;i<word.Length;i++){
            char chr = word[i];
            answer += dict[chr].point[i+1];
        }
        return answer;
    }
}