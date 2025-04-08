using System;
using System.Collections.Generic;

class Solution {
    public class XY{
        public int x;
        public int y;
        
        public XY(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
    
    public int solution(int[,] maps) {
        bool[,] visit = new bool[101,101];
        int[,] point = new int[101,101];
        int[] x = new int[]{1,0,-1,0};
        int[] y = new int[]{0,1,0,-1};
        
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                visit[i,j] = maps[i,j] == 1 ? true : false;
                point[i,j] = 0;
            }
        }
        
        point[0,0] = 1;
        visit[0,0] = false;
        Queue<XY> queue = new Queue<XY>();
        queue.Enqueue(new XY(0,0));
        
        while(queue.Count>0){
            XY xy = queue.Dequeue();
            
            for(int i=0;i<x.Length;i++){
                int nextX = xy.x+x[i];
                int nextY = xy.y+y[i];
                
                if(nextX < 0 || nextY < 0 || nextX >= n || nextY >=m)
                    continue;
                
                if(!visit[nextX,nextY])
                    continue;
                
                visit[nextX,nextY] = false;
                point[nextX,nextY] = (point[xy.x,xy.y] +1);
                queue.Enqueue(new XY(nextX,nextY));
            }
        }
         
        return point[n-1,m-1] == 0 ? -1 : point[n-1,m-1];
    }
}