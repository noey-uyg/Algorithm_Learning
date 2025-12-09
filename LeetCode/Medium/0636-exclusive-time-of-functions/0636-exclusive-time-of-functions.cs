public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        int[] result = new int[n];
        Stack<int> st = new Stack<int>();
        int prev = 0;

        foreach(var v in logs){
            string[] part = v.Split(":");
            int id = int.Parse(part[0]);
            bool isStart = part[1] == "start";
            int time = int.Parse(part[2]);

            if(isStart){
                if(st.Count > 0){
                    result[st.Peek()] += time - prev;
                }
                st.Push(id);

                prev = time;
            }else{
                result[id] += time - prev + 1;
                st.Pop();

                prev = time+1;
            }
        }

        return result;
    }
}