public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();

        foreach(var v in tokens){
            if(int.TryParse(v, out int num)){
                st.Push(num);
            }
            else{
                int b = st.Pop();
                int a = st.Pop();
                int calc = 0;

                if(v == "+"){
                    calc = a+b;
                }
                else if(v == "-"){
                    calc = a-b;
                }
                else if(v=="*"){
                    calc = a*b;
                }
                else{
                    calc = a/b;
                }

                st.Push(calc);
            }
        }

        return st.Pop();
    }
}