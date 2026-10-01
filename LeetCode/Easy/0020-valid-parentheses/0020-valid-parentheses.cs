public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        for(int i=0;i<s.Length;i++){
            if(s[i]=='(' || s[i]=='{' || s[i]=='['){
                st.Push(s[i]);
                continue;
            }

            if(st.Count == 0) return false;

            char temp = st.Peek();
            
            if(
                (temp == '(' && s[i] != ')') ||
                (temp == '{' && s[i] != '}') ||
                (temp == '[' && s[i] != ']')
            ) return false;

            st.Pop();
        }

        return st.Count == 0;
    }
}