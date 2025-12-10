public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> st = new Stack<int>();

        for(int i=0;i<temperatures.Length;i++){
            while (st.Count > 0 && temperatures[st.Peek()] < temperatures[i]){
                result[st.Peek()] = i - st.Pop();
            }
            st.Push(i);
        }

        return result;
    }
}