using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] book_time) {
        int answer = 0;
        var timeList = new List<TimeSE>();
        
        for(int i=0;i<book_time.GetLength(0);i++){
            string[] l_element = book_time[i,0].Split(":");
            string[] r_element = book_time[i,1].Split(":");
            
            int sT = (int.Parse(l_element[0])*60) + int.Parse(l_element[1]);
            int eT = (int.Parse(r_element[0])*60) + int.Parse(r_element[1]);
            
            timeList.Add(new TimeSE(sT,eT));
        }
        
        timeList.Sort(delegate(TimeSE a, TimeSE b){
            int temp = a.startTime.CompareTo(b.startTime);
            return temp != 0 ? temp : a.endTime.CompareTo(b.endTime);
        });
        
        var roomList = new List<TimeSE>();
        
        for(int i=0;i<timeList.Count;i++){
            int idx = roomList.FindIndex(x => x.endTime+10 <= timeList[i].startTime);
            
            if(idx == -1){
                roomList.Add(timeList[i]);
            }
            else{
                roomList[idx] = timeList[i];
            }
        }
        
        return roomList.Count;
    }
    
    public class TimeSE{
        public int startTime;
        public int endTime;
        
        public TimeSE(int startTime, int endTime){
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}