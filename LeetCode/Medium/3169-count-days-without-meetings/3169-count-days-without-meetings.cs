public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, (a,b) => a[0].CompareTo(b[0]));
        
        int result = 0;
        int endMeet = 0;
        foreach(var v in meetings){
            int start = v[0];
            int end = v[1];

            if(endMeet>=start){
                endMeet = Math.Max(end,endMeet);
                continue;
            }

            result += start - (endMeet+1);

            endMeet = Math.Max(end,endMeet);
        }

        return result + (days-endMeet);
    }
}