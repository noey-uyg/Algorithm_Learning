using System;
using System.Collections.Generic;

public class Solution {
    public static readonly int MAX_X = 101;
    public static readonly int MAX_Y = 101;
    public int[,] map = new int[MAX_X,MAX_Y];
    public int[,] point = new int[MAX_X,MAX_Y];
        
    public int[] dx = new int[4]{1,0,-1,0};
    public int[] dy = new int[4]{0,1,0,-1};
        
    public class Pos{
        public int x;
        public int y;
        
        public Pos(){
            
        }
        
        public Pos(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
    
    public int solution(string[] maps) {
        int maxX = maps[0].Length;
        int maxY = maps.Length;
        
        var startPos = new Pos();
        var leverPos = new Pos();
        var exitPos = new Pos();
        
        for(int i=0;i<maps.Length;i++){
            string tempStr = maps[i];
            for(int j=0;j<tempStr.Length;j++){
                point[j,i] = 0;
                
                if(tempStr[j] == 'X'){
                    map[j,i] = -1;
                    continue;
                }
                else if(tempStr[j] == 'S'){
                    startPos.x = j;
                    startPos.y = i;
                }
                else if(tempStr[j] == 'L'){
                    leverPos.x = j;
                    leverPos.y = i;
                }
                else if(tempStr[j] == 'E'){
                    exitPos.x = j;
                    exitPos.y = i;
                }

                map[j,i] = 1;
            }
        }
        
        // 레버로 갈 수 있을 때
        if(BFS(startPos, leverPos, maxX, maxY)){
            // 레버를 당기고 출구로 갈 수 있을 때
            if(BFS(leverPos, exitPos, maxX, maxY)){
                return point[exitPos.x, exitPos.y];
            }
            else
                return -1;
        }
        else
            return -1;
    }
    
    public bool BFS(Pos startPos, Pos exitPos, int maxX, int maxY){
        bool[,] visit = new bool[MAX_X,MAX_Y];
        var q = new Queue<Pos>();
        q.Enqueue(startPos);
        
        while(q.Count>0){
            Pos cur = q.Dequeue();
            visit[cur.x,cur.y] = true;
            
            if(cur.x == exitPos.x && cur.y == exitPos.y){
                return true;
                break;
            }
            
            for(int i=0;i<4;i++){
                int nx = cur.x+dx[i];
                int ny = cur.y+dy[i];
                
                if(nx < 0 || nx >= maxX || ny < 0 || ny >= maxY) // 벽일 때
                    continue;
                if(map[nx,ny]== -1) // 벽일 때
                    continue;
                
                if(visit[nx,ny]) // 방문했을 때
                    continue;
                    
                q.Enqueue(new Pos(nx,ny));
                visit[nx,ny] = true;
                point[nx,ny] = point[cur.x,cur.y]+1;
            }
        }
        
        return false;
    }
}