using System;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        int[,] costArr = new int[N+1,N+1];
        
        for(int i=1;i<=N;i++){ // 배열 초기화
            for(int j=1;j<=N;j++){
                int temp = 10000*50+1;
                
                if(i==j)
                    temp=0;
                
                costArr[i,j] = temp;
            }
        }
        
        for(int i=0;i<road.GetLength(0);i++){ //직통 가능
            int start = road[i,0];
            int end = road[i,1];
            int cost = road[i,2];
            
            costArr[start,end] = Math.Min(costArr[start,end],cost);
            costArr[end,start] = Math.Min(costArr[end,start],cost);
        }
        
        for(int i=1;i<=N;i++){ // 최소값 갱신
            for(int j=1;j<=N;j++){
                for(int k=1;k<=N;k++){
                    costArr[j,k] = Math.Min(costArr[j,k],costArr[j,i]+costArr[i,k]);
                }
            }
        }
        
        for(int i=1;i<=N;i++){
            if(costArr[1,i] <= K)
                answer++;
        }
        
        return answer;
    }
    
}