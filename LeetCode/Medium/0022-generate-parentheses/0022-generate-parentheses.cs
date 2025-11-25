public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        
        DFS(n, n, n, new StringBuilder(), result);

        return result;
    }

    public void DFS(int open, int close, int n, StringBuilder sb, IList<string> result){
        if(sb.Length == n*2){
            result.Add(sb.ToString());
            return;
        }

        if(open>0){
            sb.Append('(');
            DFS(open-1, close, n, sb, result);
            sb.Length--;
        }

        if(close>open){
            sb.Append(')');
            DFS(open, close-1, n, sb, result);
            sb.Length--;
        }
    }
}