using System;
using System.Collections.Generic;

public class Solution {
    public static readonly int MAX_X = 101;
    public static readonly int MAX_Y = 101;
    
    public int[,] map = new int[MAX_X, MAX_Y];
    public int[,] point = new int[MAX_X, MAX_Y];
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
    
    public int solution(string[] board) {
        int answer = -1;
        int maxY = board.Length;
        int maxX = board[0].Length;
        
        var startPos = new Pos();
        var targetPos = new Pos();
        
        for(int i=0;i<board.Length;i++){
            string temp = board[i];
            for(int j=0;j<temp.Length;j++){
                if(temp[j] == 'D')
                    map[i,j] = -1;
                else if(temp[j] == 'R'){
                    startPos.x = j;
                    startPos.y = i;
                }
                else if(temp[j] == 'G'){
                    targetPos.x = j;
                    targetPos.y = i;
                }
            }
        }
        
        var q = new Queue<Pos>();
        q.Enqueue(startPos);
        int count = 0;
        
        while(q.Count>0){
            Pos cur = q.Dequeue();
                        
            if(cur.x == targetPos.x && cur.y == targetPos.y){
                answer = point[targetPos.y, targetPos.x];
                break;
            }
                
            
            int curPoint = point[cur.y, cur.x];
            for(int i=0;i<4;i++){
                int nx = cur.x;
                int ny = cur.y;
                
                while(true){
                    int moveX = nx + dx[i];
                    int moveY = ny + dy[i];
                    
                    if(moveX < 0 || moveX >= maxX || moveY < 0 || moveY >= maxY)
                        break;
                    if(map[moveY,moveX] == -1)
                        break;
                    
                    nx = moveX;
                    ny = moveY;
                }
                
                if(nx == cur.x && ny == cur.y)
                    continue;
                
                if(point[ny,nx] == 0){     
                    count++;
                    point[ny,nx] = curPoint + 1;
                    q.Enqueue(new Pos(nx,ny));
                }
            }
        }
        
        return answer;
    }
}