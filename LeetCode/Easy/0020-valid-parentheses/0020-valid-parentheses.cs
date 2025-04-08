public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        for(int i=0;i<s.Length;i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                st.Push(s[i]);
                continue;
            }

            if(st.Count == 0){
                return false;
            }

            switch(st.Peek()){
                case '(':
                    if(s[i] == ')'){
                        st.Pop();
                    }
                    else{
                        return false;
                    }                 
                    break;
                case '{':
                    if(s[i] == '}'){
                        st.Pop();
                    }
                    else{
                        return false;
                    }                
                    break;
                case '[':
                    if(s[i] == ']'){
                        st.Pop();
                    }
                    else{
                        return false;
                    }                
                    break;
            }
        }

        return st.Count == 0;
    }
}