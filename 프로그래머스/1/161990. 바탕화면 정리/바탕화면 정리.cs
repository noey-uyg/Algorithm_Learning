using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int lux = 51;
        int luy = 51;
        int rdx = 0;
        int rdy = 0;
        
        for(int i=0;i<wallpaper.Length;i++){
            for(int j=0;j<wallpaper[i].Length;j++){
                string temp = wallpaper[i];
                
                if(temp[j].Equals('#')){
                    if(j<luy){
                        luy=j;
                        if(i<lux){
                            lux=i;
                        }
                    }
                    if(j>=rdy){
                        rdy=j;
                    }
                    if(i>rdx){
                        rdx=i;
                    }
                }
            }
        }
        int[] answer = new int[] {lux,luy,rdx+1,rdy+1};
        return answer;
    }
}