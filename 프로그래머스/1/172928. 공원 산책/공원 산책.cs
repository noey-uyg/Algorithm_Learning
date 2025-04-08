using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[] {0,0};
        bool[,] possible = new bool[park.Length, park[0].Length];

        int k=0;
        int[] max = new int[]{park.Length, park[0].Length};
        
        foreach(var v in park){
            int j=0;
            foreach(var a in v){
                if(a.Equals('X')){
                    possible[k,j]=false;
                }    
                else{
                    if(a.Equals('S')){
                        answer[0] = k;
                        answer[1] = j;
                    }
                    possible[k,j]=true;
                }
                j++;
            }
            k++;
        }

        for(int i=0;i<routes.Length;i++){
            string[] route = routes[i].Split(" ");
            switch(route[0]){
                case "N":
                    {
                        int route1 = int.Parse(route[1]);
                        if(answer[0] - route1 >= 0){
                            bool bTemp = false;
                            int iTemp = answer[0];
                            while(iTemp >= answer[0] - route1){
                                if(!possible[iTemp,answer[1]]){
                                    bTemp = true;
                                    break;
                                }
                                iTemp-=1;
                            }
                            
                            if(!bTemp){
                                answer[0] -= route1;
                            }
                        }
                    }
                    break;
                case "W":
                    {
                        int route1 = int.Parse(route[1]);
                        if(answer[1] - route1 >= 0){
                            bool bTemp = false;
                            int iTemp = answer[1];
                            while(iTemp>=answer[1] - route1){
                                if(!possible[answer[0],iTemp]){
                                    bTemp = true;
                                    break;
                                }
                                iTemp-=1;
                            }
                            
                            if(!bTemp){
                                answer[1] -= route1;
                            }
                        }
                    }
                    break;
                case "S":
                    {
                        int route1 = int.Parse(route[1]);
                        if(answer[0] + route1 < max[0]){
                            bool bTemp = false;
                            int iTemp = answer[0];
                            while(iTemp <= answer[0] + route1){
                                if(!possible[iTemp,answer[1]]){
                                    bTemp = true;
                                    break;
                                }
                                iTemp+=1;
                            }
                            
                            if(!bTemp){
                                answer[0] += route1;
                            }
                        }
                    }
                    break;
                case "E":
                    {
                        int route1 = int.Parse(route[1]);
                        if(answer[1] + route1 < max[1]){
                            bool bTemp = false;
                            int iTemp = answer[1];
                            while(iTemp<=answer[1] + route1){
                                if(!possible[answer[0],iTemp]){
                                    bTemp = true;
                                    break;
                                }
                                iTemp+=1;
                            }
                            
                            if(!bTemp){
                                answer[1] += route1;
                            }
                        }
                    }
                    break;
            }
        }
        return answer;
    }
}