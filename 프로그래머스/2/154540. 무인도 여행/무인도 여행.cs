using System;
using System.Collections.Generic;

public class Solution {
    public static readonly int MAP_MAX_X = 101;
    public static readonly int MAP_MAX_Y = 101;
    public int[,] map = new int[MAP_MAX_X, MAP_MAX_Y];
    public bool[,] visit = new bool[MAP_MAX_X, MAP_MAX_Y];
    public int[] dx = new int[4]{1,0,-1,0};
    public int[] dy = new int[4]{0,1,0,-1};
    
    public class Pos{
        public int x;
        public int y;
        
        public Pos(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
    
    public int[] solution(string[] maps) {
        int[] answer = new int[1]{-1};
        int mapX = maps[0].Length;
        int mapY = maps.Length;
        
        var result = new List<int>();
        
        for(int i=0;i<maps.Length;i++){
            string tempStr = maps[i];
            for(int j=0;j<tempStr.Length;j++){
                if(tempStr[j] == 'X'){
                    map[i,j] = -1;
                }
                else{
                    map[i,j] = tempStr[j] -'0';
                }
            }
        }
        
        for(int i=0;i<mapY;i++){
            for(int j=0;j<mapX;j++){
                if(map[i,j] == -1)
                    continue;
                
                if(visit[i,j])
                    continue;
                
                result.Add(BFS(new Pos(j,i), mapX, mapY));
            }
        }
        
        if(result.Count > 0){
            result.Sort();
            return result.ToArray();
        }
        
        return answer;
    }
    
    public int BFS(Pos startPos, int mapX, int mapY){
        var q = new Queue<Pos>();
        q.Enqueue(startPos);
        int sum = 0;
        
        while(q.Count>0){
            var cur = q.Dequeue();
            
            sum += map[cur.y, cur.x];
            visit[cur.y, cur.x] = true;
            
            for(int i=0;i<4;i++){
                int nx = dx[i] + cur.x;
                int ny = dy[i] + cur.y;
                
                if(nx<0 || nx>=mapX || ny<0 || ny>=mapY)
                    continue;
                
                if(map[ny,nx] == -1)
                    continue;
                
                if(visit[ny, nx])
                    continue;

                visit[ny,nx] = true;
                q.Enqueue(new Pos(nx,ny));
            }
        }
        
        return sum;
    }
}