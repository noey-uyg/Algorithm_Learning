using System;

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        int answer = 0;
        //friends의 인덱스 순서를 따름
        int[,] giveAndTake = new int[friends.Length,friends.Length]; //주고 받은 목록
        int[] point = new int[friends.Length]; //선물 지수
        
        for(int i=0;i<friends.Length;i++){
            for(int j=0;j<gifts.Length;j++){
                string[] gift = gifts[j].Split(' ');
                string give = gift[0]; // 준 사람
                string take = gift[1]; // 받은 사람

                if(give.Equals(friends[i])){
                    int takeIdx = Array.IndexOf(friends,take);
                    int giveIdx = Array.IndexOf(friends,give);
                    
                    giveAndTake[i,takeIdx]+=1;
                    point[takeIdx] -=1;
                    point[giveIdx] +=1;
                }
            }
        }
        
        //다음달에 가장 많은 선물을 받는 친구
        int max =0;
        for(int i=0;i<friends.Length;i++){
            int present =0;
            for(int j=0;j<friends.Length;j++){
                if(i==j) continue;
                
                //두 사람이 선물을 주고받은 기록이 하나도 없거나 주고받은 수가 같다면,
                if(giveAndTake[i,j] == giveAndTake[j,i]){
                    // 선물 지수가 더 큰 사람이 선물 지수가 더 작은 사람에게 선물을 하나 받습니다.
                    if(point[i] > point[j]){
                        present +=1;
                    }
                }
                //두 사람이 선물을 주고받은 기록이 있다면, 
                else{
                    //이번 달까지 두 사람 사이에 더 많은 선물을 준 사람이 다음 달에 선물을 하나 받습니다.
                    if(giveAndTake[i,j] > giveAndTake[j,i]){
                        present +=1;
                    }
                }
            }
            max = Math.Max(max,present);
        }

        return max;
    }
}