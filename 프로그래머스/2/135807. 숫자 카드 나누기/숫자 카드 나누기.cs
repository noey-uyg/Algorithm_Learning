using System;

public class Solution {
    public int solution(int[] arrayA, int[] arrayB) {
        int answer = 0;
        int gcdA = arrayA[0];
        int gcdB = arrayB[0];
        
        for(int i=1;i<arrayA.Length;i++){
            gcdA = GCD(gcdA,arrayA[i]);
            gcdB = GCD(gcdB,arrayB[i]);
        }
        
        bool enableA = gcdA==1 ? false : true;
        bool enableB = gcdB==1 ? false : true;
        
        if(gcdA!=1){
            for(int i=0;i<arrayB.Length;i++){
                if(arrayB[i]%gcdA == 0){
                    enableA=false;
                    break;
                }  
            }
        }
        
        if(gcdB!=1){
            for(int i=0;i<arrayA.Length;i++){
                if(arrayA[i]%gcdB == 0){
                    enableB=false;
                    break;
                }  
            }
        }
        
        if(!enableA && !enableB)
            answer = 0;
        else if(enableA && enableB)
            answer = Math.Max(gcdA,gcdB);
        else
            answer = enableA ? gcdA : gcdB;
        
        return answer;
    }
    
    public int GCD(int a, int b){
        if(b==0) return a;  
        return GCD(b,a%b);
    }
}