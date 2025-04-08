using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
        int max = mmssToInt(video_len.Split(':'));
        int cur = mmssToInt(pos.Split(':'));
        int opS = mmssToInt(op_start.Split(':'));
        int opE = mmssToInt(op_end.Split(':'));
        
        for(int i=0;i<commands.Length;i++){
            cur = opening(cur,opS,opE);
            
            cur = commands[i].Equals("next") ?
                Math.Min(cur+10, max) :
                Math.Max(cur-10, 0);
            
            cur = opening(cur,opS,opE);
        }
        return IntTommss(cur);
    }
    
    public int mmssToInt(string[] mmss){
        int mm = int.Parse(mmss[0])*60;
        int ss = int.Parse(mmss[1]);
        
        return mm+ss;
    }
    
    public string IntTommss(int result){
        int mm = result/60;
        int ss = result%60;
        string strmm ="";
        string strss ="";
        if(mm<10){
            strmm = "0"+mm.ToString();
        }
        else{
            strmm = mm.ToString();
        }
        if(ss<10){
            strss = "0"+ss.ToString();
        }
        else{
            strss = ss.ToString();
        }
        
        return strmm+":"+strss;
    }
    
    public int opening(int cur, int opS, int opE){
        if(opS<=cur && cur<=opE){
            return opE;
        }
        
        return cur;
    }
}